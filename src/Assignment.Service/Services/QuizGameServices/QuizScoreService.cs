using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Api.Interfaces.QuizGameInterfaces;
using Assignment.Api.Models.QuizGame;
using Assignment.Service.Model.QuizGame;
using iText.Kernel.Pdf;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;

namespace Assignment.Service.Services.QuizGameServices
{
    public class QuizScoreService
    {
        private readonly IDBQuizScoreRepository _quizScoreRepository;

        public QuizScoreService(IDBQuizScoreRepository quizScoreRepository)
        {
            _quizScoreRepository = quizScoreRepository;
        }

        public async Task<QuizScoreDetailRS> GetScoreDetailsByUserIdAndQuizIdAsync(int userId, int quizId)
        {
            var quizScore = await _quizScoreRepository.GetScoreDetailsByUserIdAndQuizIdAsync(userId, quizId);

            if (quizScore == null)
            {
                // Handle the case where no score details are found for the user and quiz
                return null;
            }

            return new QuizScoreDetailRS
            {
                UserName = quizScore.User?.Username,
                Score = quizScore.Score,
                QuizTitle = quizScore.Quiz.Title,
                WinPercentage = CalculateWinPercentage(quizScore)
            };
        }


        private double CalculateWinPercentage(QuizScore quizScore)
        {
            if (quizScore.Quiz == null || quizScore.Quiz.NumberOfQuestions == 0)
            {
                return 0; // Handle edge cases
            }

            double totalQuestions = quizScore.Quiz.NumberOfQuestions;
            double totalScore = quizScore.Score;

            return (totalScore / totalQuestions) * 100;
        }

        public async Task<byte[]> GenerateLeaderboardPDF()
        {
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    // Create a PdfWriter that writes to the memory stream
                    using (PdfWriter writer = new PdfWriter(memoryStream))
                    {
                        // Create a PdfDocument that uses the writer
                        using (PdfDocument pdf = new PdfDocument(writer))
                        {
                            // Create a document
                            Document document = new Document(pdf);

                            // Add content to the PDF
                            document.Add(new Paragraph("Leaderboard")
                                .SetTextAlignment(TextAlignment.CENTER)
                                .SetFontSize(20)
                                .SetBold());

                            await AddLeaderboard(document);

                            // Close the document
                            document.Close();

                            return memoryStream.ToArray();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task AddLeaderboard(Document document)
        {
            var leaderboard = await _quizScoreRepository.GetLeaderboardAsync();

            var leaderboardResponses = leaderboard.Select(qs => new QuizScoreRS
            {
                UserName = qs.User != null ? qs.User.Username : "N/A",
                Email = qs.User != null ? qs.User.Email : "N/A",
                QuizTitle = qs.Quiz != null ? qs.Quiz.Title : "N/A",
                Score = qs.Score
            }).ToList();

            // Add a table to display leaderboard
            Table leaderboardTable = new Table(4)
                .UseAllAvailableWidth()
                .SetBorder(Border.NO_BORDER);

            // Adding header cells
            leaderboardTable.AddHeaderCell(new Cell().Add(new Paragraph("UserName"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            leaderboardTable.AddHeaderCell(new Cell().Add(new Paragraph("Email"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            leaderboardTable.AddHeaderCell(new Cell().Add(new Paragraph("QuizTitle"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));
            leaderboardTable.AddHeaderCell(new Cell().Add(new Paragraph("Score"))
                .SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY)
                .SetTextAlignment(TextAlignment.CENTER));

            // Adding data cells
            foreach (var entry in leaderboardResponses)
            {
                leaderboardTable.AddCell(new Cell().Add(new Paragraph(entry.UserName.ToString()))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));

                leaderboardTable.AddCell(new Cell().Add(new Paragraph(entry.Email.ToString()))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));

                leaderboardTable.AddCell(new Cell().Add(new Paragraph(entry.QuizTitle.ToString()))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));

                leaderboardTable.AddCell(new Cell().Add(new Paragraph(entry.Score.ToString()))
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER));
            }

            document.Add(leaderboardTable);
        }
    }
}
