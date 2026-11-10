using System;
using System.Collections.Generic;
using System.Linq;

namespace Course_Registration
{
    /// <summary>
    /// Lớp nghiệp vụ xử lý kiểm tra trùng lịch học, định dạng thời khóa biểu
    /// và tính toán mức miễn giảm học bổng bằng LINQ.
    /// </summary>
    public static class ScheduleHelper
    {
        public static readonly string[] StudyDaysOptions = new string[]
        {
            "2,4,6",
            "3,5,7",
            "7,CN",
            "2,4",
            "3,5"
        };

        public static readonly string[] StudyShiftOptions = new string[]
        {
            "Ca sáng (08:00 - 10:30)",
            "Ca chiều (14:00 - 16:30)",
            "Ca tối (18:00 - 20:30)"
        };

        public static readonly string[] DayColumns = new string[]
        {
            "2", "3", "4", "5", "6", "7", "CN"
        };

        public static List<string> ParseDays(string studyDays)
        {
            if (string.IsNullOrWhiteSpace(studyDays))
            {
                return new List<string>();
            }

            return studyDays
                .Split(new char[] { ',', ';', '-', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(d => d.Trim().ToUpperInvariant())
                .Distinct()
                .ToList();
        }

        public static string NormalizeShiftKey(string shift)
        {
            if (string.IsNullOrWhiteSpace(shift))
            {
                return string.Empty;
            }

            string lower = shift.Trim().ToLowerInvariant();
            if (lower.Contains("sáng")) return "SANG";
            if (lower.Contains("chiều")) return "CHIEU";
            if (lower.Contains("tối")) return "TOI";
            return lower;
        }

        public static bool HasScheduleConflict(
            string daysA,
            string shiftA,
            string daysB,
            string shiftB,
            out string overlappingDaysDisplay)
        {
            overlappingDaysDisplay = string.Empty;

            string keyA = NormalizeShiftKey(shiftA);
            string keyB = NormalizeShiftKey(shiftB);
            if (string.IsNullOrEmpty(keyA) || keyA != keyB)
            {
                return false;
            }

            List<string> listA = ParseDays(daysA);
            List<string> listB = ParseDays(daysB);

            List<string> overlap = listA.Intersect(listB, StringComparer.OrdinalIgnoreCase).ToList();
            if (overlap.Count == 0)
            {
                return false;
            }

            overlappingDaysDisplay = FormatDaysText(string.Join(",", overlap));
            return true;
        }

        public static string FormatDaysText(string studyDays)
        {
            List<string> days = ParseDays(studyDays);
            if (days.Count == 0)
            {
                return "Chưa xếp lịch";
            }

            if (days.Count == 1 && days[0] == "CN")
            {
                return "Chủ nhật";
            }

            List<string> labels = days
                .Select(d => d == "CN" ? "CN" : d)
                .ToList();
            return "Thứ " + string.Join(", ", labels);
        }

        public static string FormatShortSchedule(string studyDays, string studyShift)
        {
            string shortShift = studyShift ?? string.Empty;
            int idx = shortShift.IndexOf('(');
            if (idx > 0)
            {
                shortShift = shortShift.Substring(0, idx).Trim();
            }

            return FormatDaysText(studyDays) + " - " + shortShift;
        }

        public static decimal CalculateVoucherDiscount(Voucher voucher, decimal coursePrice, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (voucher == null)
            {
                errorMessage = "Mã học bổng / ưu đãi không tồn tại.";
                return 0m;
            }

            if (!voucher.IsActive)
            {
                errorMessage = "Mã ưu đãi này hiện đang tạm ngưng áp dụng.";
                return 0m;
            }

            if (voucher.ExpiryDate.Date < DateTime.Today)
            {
                errorMessage = string.Format("Mã ưu đãi đã hết hạn sử dụng từ ngày {0:dd/MM/yyyy}.", voucher.ExpiryDate);
                return 0m;
            }

            if (voucher.UsedCount >= voucher.UsageLimit)
            {
                errorMessage = "Mã ưu đãi đã hết lượt sử dụng.";
                return 0m;
            }

            if (coursePrice < voucher.MinOrderAmount)
            {
                errorMessage = string.Format("Mã này áp dụng cho khóa học có học phí từ {0:N0} VNĐ trở lên.", voucher.MinOrderAmount);
                return 0m;
            }

            decimal discount = 0m;
            if (voucher.DiscountPercent > 0)
            {
                discount = Math.Round(coursePrice * voucher.DiscountPercent / 100m, 0);
                if (voucher.MaxDiscountAmount > 0 && discount > voucher.MaxDiscountAmount)
                {
                    discount = voucher.MaxDiscountAmount;
                }
            }
            else
            {
                discount = voucher.DiscountAmount;
            }

            if (discount > coursePrice)
            {
                discount = coursePrice;
            }

            return discount;
        }

        public static string FormatStars(double avgRating, int count)
        {
            if (count <= 0)
            {
                return "Chưa có";
            }

            return string.Format("{0:0.0}/5 ★ ({1})", avgRating, count);
        }
    }
}

