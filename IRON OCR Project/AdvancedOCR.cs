using IronOcr;
using IronSoftware.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRON_OCR_Project
{
    public  class AdvancedOCR
    {
        private int x_axis;
        private int y_axis;
        private int width;
        private int height;
        private string imagePath;
        private int scale;
        private string saveFileWithName;
        IronTesseract Ocr;
        public AdvancedOCR(string imagePath, int scale, string saveFileWithName, int xaxis, int yaxis, int width, int height)
        {
            this.x_axis = xaxis;
            this.y_axis = yaxis;
            this.width = width;
            this.height = height;
            this.imagePath = imagePath;
            this.scale = scale;
            this.saveFileWithName = saveFileWithName;
            this.Ocr = new IronTesseract();
        }

        private CropRectangle CropRect
        {
            get
            {
                return new CropRectangle(x_axis, y_axis, width, height);
            }
        }

        private void settingUp_OCR()
        {
            this.Ocr.UseCustomTesseractLanguageFile(@"tessdata_arabic-master\ara-Scheherazade.traineddata");
            this.Ocr.Configuration.BlackListCharacters = "1234567890\"'؟!÷×؛~ْ^%،<>+=*::!@#$%^&*()_+QWERTYUIOPASDFGHJKL;ZXCVBNM,??qwertyuiopasdfghjklzxcvbnm~`$#^*_}{][|\\@¢©«»°±·×‑–—‘’“”•…′″€™←↑→↓↔⇄⇒∅∼≅≈≠≤≥≪≫⌁⌘○◔◑◕●☐☑☒☕☮☯☺♡⚓✓✰";
           // this.Ocr.Configuration.PageSegmentationMode = TesseractPageSegmentationMode.SingleWord;
        }

        public void print_Front_ID_Info(bool Binarize = false, bool DeNoise = false, bool Erode = false, bool Sharpen = false)
        {
            //
            settingUp_OCR();
            int pageIndex = 0;
            using (var input = new OcrInput(imagePath))
            {
                // Find the text region using Computer Vision

                //input.FindMultipleTextRegions(Scale: 2.0, DilationAmount: -1, Binarize: true, Invert: false);
                //OcrResult result = Ocr.Read(input);
                //string resultText = result.Text;

                //Console.WriteLine(resultText);

                var selectedPage = input.Pages[pageIndex];
                List<CropRectangle> regions = selectedPage.GetTextRegions();
                for (int i = 0; i < regions.Count(); i++)
                {
                    Console.WriteLine(regions[i]);
                }
                
            }

        }

        public void print_Back_ID_Info(bool Binarize = false, bool DeNoise = false, bool Erode = false, bool Sharpen = false)
        {
            settingUp_OCR();

            using (var ocrInput = new OcrInput())
            {
                CropRectangle rec = this.CropRect;

                Bitmap bm = (Bitmap)Bitmap.FromFile(imagePath);
                ocrInput.AddImage(bm, rec);

                if (Binarize)
                {
                    ocrInput.Binarize();
                }
                if (DeNoise)
                {
                    ocrInput.DeNoise();
                }

                if (Sharpen)
                {
                    ocrInput.Sharpen();
                }
                if (Erode)
                {
                    ocrInput.Erode();
                }

                ocrInput.SelectTextColor(IronSoftware.Drawing.Color.Black);


                //ocrInput.Scale(scale);
                ocrInput.StampCropRectangleAndSaveAs(rec, IronSoftware.Drawing.Color.Red, saveFileWithName);

                var ocrResult = Ocr.Read(ocrInput);

                Console.WriteLine(ocrResult.Text);
                Console.WriteLine("-----------------------------------------------------------------------");

                ocrResult.SaveAsSearchablePdf($"../../../OCR_Result/{saveFileWithName}.pdf");
                ocrResult.SaveAsTextFile($"../../../OCR_Result/{saveFileWithName}.txt");

            }

        }
    }
}
