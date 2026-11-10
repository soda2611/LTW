using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Course_Registration
{
    /// <summary>
    /// Lớp hỗ trợ xuất dữ liệu chuyên nghiệp từ DataGridView ra tệp Excel (.xlsx Office Open XML / .xls / .csv).
    /// Hỗ trợ chuẩn .xlsx nguyên bản 100%, không cần cài Microsoft Office, mở trực tiếp không báo lỗi định dạng.
    /// </summary>
    public static class ExcelExporter
    {
        public static void ExportDataGridView(DataGridView dgv, SaveFileDialog saveDialog, string reportTitle, string defaultFileName)
        {
            if (dgv == null || dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong bảng để xuất báo cáo.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (saveDialog == null)
            {
                saveDialog = new SaveFileDialog();
            }

            saveDialog.Filter = "Bảng tính Excel (*.xlsx)|*.xlsx|Bảng tính Excel 97-2003 (*.xls)|*.xls|Tệp CSV UTF-8 (*.csv)|*.csv";
            saveDialog.DefaultExt = "xlsx";
            saveDialog.FilterIndex = 1;
            saveDialog.Title = "Xuất dữ liệu ra Excel";
            saveDialog.FileName = defaultFileName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmm") + ".xlsx";

            if (saveDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            List<DataGridViewColumn> visibleCols = dgv.Columns
                .Cast<DataGridViewColumn>()
                .Where(c => c.Visible)
                .OrderBy(c => c.DisplayIndex)
                .ToList();

            string ext = Path.GetExtension(saveDialog.FileName).ToLowerInvariant();
            try
            {
                if (ext == ".csv")
                {
                    WriteCsv(dgv, visibleCols, saveDialog.FileName);
                }
                else if (ext == ".xls")
                {
                    WriteHtmlExcel(dgv, visibleCols, saveDialog.FileName, reportTitle);
                }
                else
                {
                    WriteXlsx(dgv, visibleCols, saveDialog.FileName, reportTitle);
                }

                MessageBox.Show("Đã xuất dữ liệu thành công ra tệp Excel:\n" + saveDialog.FileName,
                    "Xuất báo cáo thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể ghi tệp báo cáo:\n" + ex.Message,
                    "Lỗi xuất dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region OpenXML XLSX Generation (No Office Interop Needed)

        private static void WriteXlsx(DataGridView dgv, List<DataGridViewColumn> cols, string filePath, string reportTitle)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (ZipArchive zip = new ZipArchive(fs, ZipArchiveMode.Create))
            {
                // 1. [Content_Types].xml
                WriteZipEntry(zip, "[Content_Types].xml", @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Types xmlns=""http://schemas.openxmlformats.org/package/2006/content-types"">
  <Default Extension=""rels"" ContentType=""application/vnd.openxmlformats-package.relationships+xml""/>
  <Default Extension=""xml"" ContentType=""application/xml""/>
  <Override PartName=""/xl/workbook.xml"" ContentType=""application/vnd.openxmlformats-officedocument.spreadsheetml.sheet.main+xml""/>
  <Override PartName=""/xl/worksheets/sheet1.xml"" ContentType=""application/vnd.openxmlformats-officedocument.spreadsheetml.worksheet+xml""/>
  <Override PartName=""/xl/styles.xml"" ContentType=""application/vnd.openxmlformats-officedocument.spreadsheetml.styles+xml""/>
</Types>");

                // 2. _rels/.rels
                WriteZipEntry(zip, "_rels/.rels", @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships"">
  <Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument"" Target=""xl/workbook.xml""/>
</Relationships>");

                // 3. xl/_rels/workbook.xml.rels
                WriteZipEntry(zip, "xl/_rels/workbook.xml.rels", @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<Relationships xmlns=""http://schemas.openxmlformats.org/package/2006/relationships"">
  <Relationship Id=""rId1"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/worksheet"" Target=""worksheets/sheet1.xml""/>
  <Relationship Id=""rId2"" Type=""http://schemas.openxmlformats.org/officeDocument/2006/relationships/styles"" Target=""styles.xml""/>
</Relationships>");

                // 4. xl/workbook.xml
                WriteZipEntry(zip, "xl/workbook.xml", @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<workbook xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"" xmlns:r=""http://schemas.openxmlformats.org/officeDocument/2006/relationships"">
  <sheets>
    <sheet name=""BaoCaoDuLieu"" sheetId=""1"" r:id=""rId1""/>
  </sheets>
</workbook>");

                // 5. xl/styles.xml
                WriteZipEntry(zip, "xl/styles.xml", @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>
<styleSheet xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">
  <numFmts count=""1"">
    <numFmt numFmtId=""164"" formatCode=""#,##0""/>
  </numFmts>
  <fonts count=""5"">
    <font><name val=""Segoe UI""/><sz val=""10""/><color rgb=""FF0F172A""/></font>
    <font><name val=""Segoe UI""/><sz val=""10""/><b/><color rgb=""FFFFFFFF""/></font>
    <font><name val=""Segoe UI""/><sz val=""14""/><b/><color rgb=""FF1B3A6B""/></font>
    <font><name val=""Segoe UI""/><sz val=""9.5""/><i/><color rgb=""FF64748B""/></font>
    <font><name val=""Segoe UI""/><sz val=""10""/><b/><color rgb=""FF1E293B""/></font>
  </fonts>
  <fills count=""4"">
    <fill><patternFill patternType=""none""/></fill>
    <fill><patternFill patternType=""gray125""/></fill>
    <fill><patternFill patternType=""solid""><fgColor rgb=""FF1B3A6B""/></patternFill></fill>
    <fill><patternFill patternType=""solid""><fgColor rgb=""FFF8FAFC""/></patternFill></fill>
  </fills>
  <borders count=""2"">
    <border><left/><right/><top/><bottom/><diagonal/></border>
    <border>
      <left style=""thin""><color rgb=""FFE2E8F0""/></left>
      <right style=""thin""><color rgb=""FFE2E8F0""/></right>
      <top style=""thin""><color rgb=""FFE2E8F0""/></top>
      <bottom style=""thin""><color rgb=""FFE2E8F0""/></bottom>
    </border>
  </borders>
  <cellStyleXfs count=""1"">
    <xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""0""/>
  </cellStyleXfs>
  <cellXfs count=""7"">
    <xf numFmtId=""0"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyFont=""1"" applyBorder=""1""/>
    <xf numFmtId=""0"" fontId=""1"" fillId=""2"" borderId=""1"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""center"" vertical=""center""/></xf>
    <xf numFmtId=""0"" fontId=""2"" fillId=""0"" borderId=""0"" xfId=""0"" applyFont=""1"" applyAlignment=""1""><alignment vertical=""center""/></xf>
    <xf numFmtId=""0"" fontId=""3"" fillId=""0"" borderId=""0"" xfId=""0"" applyFont=""1"" applyAlignment=""1""><alignment vertical=""center""/></xf>
    <xf numFmtId=""164"" fontId=""0"" fillId=""0"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFont=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
    <xf numFmtId=""0"" fontId=""0"" fillId=""3"" borderId=""1"" xfId=""0"" applyFont=""1"" applyFill=""1"" applyBorder=""1""/>
    <xf numFmtId=""164"" fontId=""0"" fillId=""3"" borderId=""1"" xfId=""0"" applyNumberFormat=""1"" applyFont=""1"" applyFill=""1"" applyBorder=""1"" applyAlignment=""1""><alignment horizontal=""right"" vertical=""center""/></xf>
  </cellXfs>
</styleSheet>");

                // 6. xl/worksheets/sheet1.xml
                string sheetXml = BuildWorksheetXml(dgv, cols, reportTitle);
                WriteZipEntry(zip, "xl/worksheets/sheet1.xml", sheetXml);
            }
        }

        private static string BuildWorksheetXml(DataGridView dgv, List<DataGridViewColumn> cols, string reportTitle)
        {
            int colCount = cols.Count;
            if (colCount == 0) colCount = 1;
            string lastColLetter = GetColumnLetter(colCount - 1);

            // Đo độ rộng thích ứng cho từng cột
            int[] colMaxLengths = new int[colCount];
            for (int i = 0; i < colCount; i++)
            {
                colMaxLengths[i] = Math.Max(10, (cols[i].HeaderText ?? string.Empty).Length);
            }

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                for (int i = 0; i < colCount; i++)
                {
                    string text = Convert.ToString(row.Cells[cols[i].Index].FormattedValue ?? string.Empty);
                    if (text.Length > colMaxLengths[i])
                    {
                        colMaxLengths[i] = Math.Min(45, text.Length);
                    }
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(@"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""yes""?>");
            sb.AppendLine(@"<worksheet xmlns=""http://schemas.openxmlformats.org/spreadsheetml/2006/main"">");

            // Columns width definition
            sb.AppendLine("  <cols>");
            for (int i = 0; i < colCount; i++)
            {
                double width = Math.Max(12.0, colMaxLengths[i] + 4.5);
                sb.AppendFormat(CultureInfo.InvariantCulture, @"    <col min=""{0}"" max=""{0}"" width=""{1:F2}"" customWidth=""1""/>{2}",
                    i + 1, width, Environment.NewLine);
            }
            sb.AppendLine("  </cols>");

            sb.AppendLine("  <sheetData>");

            // Row 1: Title Banner (merged)
            sb.AppendLine(@"    <row r=""1"" ht=""32"" customHeight=""1"">");
            sb.AppendFormat(@"      <c r=""A1"" s=""2"" t=""inlineStr""><is><t>{0}</t></is></c>{1}",
                EscapeXml(reportTitle), Environment.NewLine);
            sb.AppendLine("    </row>");

            // Row 2: Subtitle Metadata
            sb.AppendLine(@"    <row r=""2"" ht=""20"" customHeight=""1"">");
            string metaText = string.Format("Thời gian kết xuất: {0:dd/MM/yyyy HH:mm:ss} | Tổng số bản ghi: {1} | Hệ thống Course Registration",
                DateTime.Now, dgv.Rows.Count);
            sb.AppendFormat(@"      <c r=""A2"" s=""3"" t=""inlineStr""><is><t>{0}</t></is></c>{1}",
                EscapeXml(metaText), Environment.NewLine);
            sb.AppendLine("    </row>");

            // Row 3: Empty spacing row
            sb.AppendLine(@"    <row r=""3"" ht=""14"" customHeight=""1""/>");

            // Row 4: Header Columns
            sb.AppendLine(@"    <row r=""4"" ht=""26"" customHeight=""1"">");
            for (int i = 0; i < colCount; i++)
            {
                string cellRef = GetColumnLetter(i) + "4";
                sb.AppendFormat(@"      <c r=""{0}"" s=""1"" t=""inlineStr""><is><t>{1}</t></is></c>{2}",
                    cellRef, EscapeXml(cols[i].HeaderText), Environment.NewLine);
            }
            sb.AppendLine("    </row>");

            // Rows 5+: Data Rows
            int rowIndex = 5;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;

                bool isEvenRow = (rowIndex % 2 == 0);
                sb.AppendFormat(@"    <row r=""{0}"" ht=""22"" customHeight=""1"">{1}", rowIndex, Environment.NewLine);

                for (int i = 0; i < colCount; i++)
                {
                    string cellRef = GetColumnLetter(i) + rowIndex.ToString();
                    object rawValue = row.Cells[cols[i].Index].Value;
                    string formatted = Convert.ToString(row.Cells[cols[i].Index].FormattedValue ?? string.Empty);
                    string colHeader = (cols[i].HeaderText ?? string.Empty).ToLowerInvariant();

                    // Kiểm tra xem cột có phải là dạng số nguyên/tiền tệ để hiển thị căn phải và có định dạng phân cách
                    decimal numVal;
                    bool isCurrencyOrCount = (colHeader.Contains("tiền") || colHeader.Contains("giá") || colHeader.Contains("phí")
                                              || colHeader.Contains("số dư") || colHeader.Contains("lượt") || colHeader.Contains("giờ")
                                              || colHeader.Contains("học viên") || colHeader.Contains("doanh thu"));

                    // Tránh biến đổi các mã code hoặc số điện thoại thành số học
                    bool isCodeOrPhone = (colHeader.Contains("mã") || colHeader.Contains("điện thoại") || colHeader.Contains("phone") || colHeader.Contains("stt"));

                    if (!isCodeOrPhone && isCurrencyOrCount && TryParseNumber(rawValue, formatted, out numVal))
                    {
                        int numStyle = isEvenRow ? 6 : 4;
                        sb.AppendFormat(CultureInfo.InvariantCulture,
                            @"      <c r=""{0}"" s=""{1}""><v>{2:0.##}</v></c>{3}",
                            cellRef, numStyle, numVal, Environment.NewLine);
                    }
                    else
                    {
                        int textStyle = isEvenRow ? 5 : 0;
                        string cleanText = formatted.Replace("\r\n", " | ").Replace("\n", " | ");
                        sb.AppendFormat(@"      <c r=""{0}"" s=""{1}"" t=""inlineStr""><is><t>{2}</t></is></c>{3}",
                            cellRef, textStyle, EscapeXml(cleanText), Environment.NewLine);
                    }
                }

                sb.AppendLine("    </row>");
                rowIndex++;
            }

            sb.AppendLine("  </sheetData>");

            // Auto-filter on header
            if (rowIndex > 5)
            {
                sb.AppendFormat(@"  <autoFilter ref=""A4:{0}{1}""/>{2}", lastColLetter, rowIndex - 1, Environment.NewLine);
            }

            // Merged title banner
            sb.AppendLine("  <mergeCells count=\"2\">");
            sb.AppendFormat(@"    <mergeCell ref=""A1:{0}1""/>{1}", lastColLetter, Environment.NewLine);
            sb.AppendFormat(@"    <mergeCell ref=""A2:{0}2""/>{1}", lastColLetter, Environment.NewLine);
            sb.AppendLine("  </mergeCells>");

            sb.AppendLine("</worksheet>");
            return sb.ToString();
        }

        private static bool TryParseNumber(object rawVal, string formatted, out decimal result)
        {
            if (rawVal != null)
            {
                if (rawVal is decimal) { result = (decimal)rawVal; return true; }
                if (rawVal is int) { result = (decimal)(int)rawVal; return true; }
                if (rawVal is long) { result = (decimal)(long)rawVal; return true; }
                if (rawVal is double) { result = (decimal)(double)rawVal; return true; }
            }

            if (!string.IsNullOrEmpty(formatted))
            {
                string cleaned = formatted.Replace("VNĐ", "").Replace("VND", "").Replace("đ", "")
                                          .Replace(",", "").Replace(".", "").Replace(" ", "").Trim();
                if (decimal.TryParse(cleaned, NumberStyles.Any, CultureInfo.InvariantCulture, out result))
                {
                    return true;
                }
            }

            result = 0m;
            return false;
        }

        private static string GetColumnLetter(int colIndex)
        {
            string col = string.Empty;
            colIndex++;
            while (colIndex > 0)
            {
                int rem = (colIndex - 1) % 26;
                col = (char)('A' + rem) + col;
                colIndex = (colIndex - 1) / 26;
            }
            return col;
        }

        private static string EscapeXml(string input)
        {
            if (string.IsNullOrEmpty(input)) return string.Empty;
            return input.Replace("&", "&amp;")
                        .Replace("<", "&lt;")
                        .Replace(">", "&gt;")
                        .Replace("\"", "&quot;")
                        .Replace("'", "&apos;");
        }

        private static void WriteZipEntry(ZipArchive zip, string entryName, string content)
        {
            ZipArchiveEntry entry = zip.CreateEntry(entryName, CompressionLevel.Optimal);
            using (Stream s = entry.Open())
            using (StreamWriter sw = new StreamWriter(s, new UTF8Encoding(false)))
            {
                sw.Write(content);
            }
        }

        #endregion

        #region Legacy CSV & HTML Excel

        private static void WriteCsv(DataGridView dgv, List<DataGridViewColumn> cols, string filePath)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Join(",", cols.Select(c => EscapeCsv(c.HeaderText ?? string.Empty))));

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                List<string> cells = new List<string>();
                foreach (DataGridViewColumn col in cols)
                {
                    string formatted = Convert.ToString(row.Cells[col.Index].FormattedValue ?? string.Empty);
                    formatted = formatted.Replace("\r\n", " | ").Replace("\n", " | ");
                    cells.Add(EscapeCsv(formatted));
                }
                sb.AppendLine(string.Join(",", cells));
            }

            File.WriteAllText(filePath, sb.ToString(), new UTF8Encoding(true));
        }

        private static string EscapeCsv(string input)
        {
            if (input == null) return "\"\"";
            return "\"" + input.Replace("\"", "\"\"") + "\"";
        }

        private static void WriteHtmlExcel(DataGridView dgv, List<DataGridViewColumn> cols, string filePath, string reportTitle)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("<html><head><meta http-equiv=\"Content-Type\" content=\"text/html; charset=utf-8\" />");
            sb.AppendLine("<style>");
            sb.AppendLine("body { font-family: 'Segoe UI', Arial, sans-serif; font-size: 11pt; }");
            sb.AppendLine("h2 { color: #1e293b; margin-bottom: 4px; }");
            sb.AppendLine(".meta { color: #475569; font-size: 10pt; margin-bottom: 12px; }");
            sb.AppendLine("table { border-collapse: collapse; width: 100%; }");
            sb.AppendLine("th { background-color: #1B3A6B; color: #ffffff; font-weight: bold; border: 1px solid #94a3b8; padding: 8px; text-align: left; }");
            sb.AppendLine("td { border: 1px solid #cbd5e1; padding: 6px 8px; vertical-align: top; mso-number-format:'\\@'; }");
            sb.AppendLine("</style></head><body>");

            sb.AppendLine("<h2>" + WebUtility.HtmlEncode(reportTitle) + "</h2>");
            sb.AppendLine("<div class=\"meta\">Thời gian kết xuất: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") +
                          " | Tổng số dòng: " + dgv.Rows.Count + "</div>");

            sb.AppendLine("<table><thead><tr>");
            foreach (DataGridViewColumn col in cols)
            {
                sb.AppendLine("<th>" + WebUtility.HtmlEncode(col.HeaderText ?? string.Empty) + "</th>");
            }
            sb.AppendLine("</tr></thead><tbody>");

            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.IsNewRow) continue;
                sb.AppendLine("<tr>");
                foreach (DataGridViewColumn col in cols)
                {
                    string text = Convert.ToString(row.Cells[col.Index].FormattedValue ?? string.Empty);
                    string encoded = WebUtility.HtmlEncode(text).Replace("\r\n", "<br/>").Replace("\n", "<br/>");
                    sb.AppendLine("<td>" + encoded + "</td>");
                }
                sb.AppendLine("</tr>");
            }

            sb.AppendLine("</tbody></table></body></html>");
            File.WriteAllText(filePath, sb.ToString(), new UTF8Encoding(true));
        }

        #endregion
    }
}
