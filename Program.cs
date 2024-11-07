// See https://aka.ms/new-console-template for more information
using System;
using IronOcr;
IronOcr.License.LicenseKey = "IRONSUITE.GOPI.BATTINENI.UNICAM.IT.7606-847DD398C6-BBYRI6XYCNWCKJ-GHIY6HANNZHP-FPHSVNEK6QJK-YB5G3FNEQJW4-6SFJ737YTTWZ-TLBNTMODOMNK-46FAFQ-TDXKJ7LNPFKOEA-DEPLOYMENT.TRIAL-K6FSYL.TRIAL.EXPIRES.07.DEC.2024";

namespace OCR
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            var ocr = new IronTesseract();
            using (var input = new OcrInput(@"C:\Users\utente\Desktop\OCR\OCR\OCR\Images\2.tiff"))
            {
                var result = ocr.Read(input);
                result.SaveAsTextFile(@"Images\1.txt"); // Save result as a text file

                Console.WriteLine(result.Text); // Display result in the console
            }
        }
    }
}
