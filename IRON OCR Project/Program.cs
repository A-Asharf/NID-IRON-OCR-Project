using BitMiracle.LibTiff.Classic;
using IronOcr;

var Ocr = new IronTesseract();
Ocr.Language = OcrLanguage.ArabicAlphabetBest;
Ocr.AddSecondaryLanguage(OcrLanguage.ArabicAlphabetFast);
Ocr.UseCustomTesseractLanguageFile(@"tessdata_arabic-master\ara-Amiri.traineddata");
//Ocr.UseCustomTesseractLanguageFile(@"ara.traineddata");
//Ocr.Configuration.BlackListCharacters = "~`$#^*_}{][|\\@¢©«»°±·×‑–—‘’“”•…′″€™←↑→↓↔⇄⇒∅∼≅≈≠≤≥≪≫⌁⌘○◔◑◕●☐☑☒☕☮☯☺♡⚓✓✰";
Ocr.Configuration.BlackListCharacters = "\"'؟!÷×؛~ْ^%،<>+=*::!@#$%^&*()_+QWERTYUIOPASDFGHJKL;ZXCVBNM,??qwertyuiopasdfghjklzxcvbnm~`$#^*_}{][|\\@¢©«»°±·×‑–—‘’“”•…′″€™←↑→↓↔⇄⇒∅∼≅≈≠≤≥≪≫⌁⌘○◔◑◕●☐☑☒☕☮☯☺♡⚓✓✰";
Ocr.Configuration.PageSegmentationMode = TesseractPageSegmentationMode.Auto;
Ocr.Configuration.ReadBarCodes = false;



using (var ocrInput = new OcrInput("../../../Images/ID-Face.jpg"))
{

    ocrInput.Deskew();
    ocrInput.DeNoise();
    //ocrInput.Despeckle();
    
    ocrInput.EnhanceResolution(290);//200
    //ocrInput.Sharpen();
    
    //ocrInput.Erode();
    //ocrInput.Open();
    ocrInput.ToGrayScale();
    ocrInput.Binarize();
    //ocrInput.DeNoise();
    //ocrInput.Sharpen();
    //ocrInput.Dilate();// => bad result
    ocrInput.Scale(50); //80


    var ocrResult = Ocr.Read(ocrInput);

    Console.WriteLine(ocrResult.Text);
    ocrResult.SaveAsSearchablePdf("../../../OCR_Result/arabic_Face.pdf");
    ocrResult.SaveAsTextFile("../../../OCR_Result/arabic_Face.txt");
    //Check if the file exists

}


using (var ocrInput = new OcrInput("../../../Images/ID-Back.jpg"))
{

    //ocrInput.Deskew();
    //ocrInput.DeNoise();
    ocrInput.Despeckle();

    ocrInput.EnhanceResolution(200); //200

    ocrInput.Sharpen();
    ocrInput.Erode();


    //ocrInput.Dilate();
    ocrInput.Scale(130); //130


    var ocrResult = Ocr.Read(ocrInput);

    Console.WriteLine(ocrResult.Text);
    ocrResult.SaveAsSearchablePdf("../../../OCR_Result/arabic_back.pdf");
    ocrResult.SaveAsTextFile("../../../OCR_Result/arabic_back.txt");
    //Check if the file exists

}
