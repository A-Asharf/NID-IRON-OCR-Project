﻿
namespace IRON_OCR_Project
{
    public class Program
    {
        public static void Main()
        {
            // var face_IdCard = new IDCardOCR("../../../Images/ID-Face.jpg",24, "arabic_Face_rec", 900, 300, 1003, 800);
            // // scale = 24
            //face_IdCard.print_Front_ID_Info(true,true);



            ////-------------------------------------------- [ Id card Face Name => Done ( ✔️ ) ] -------------------------------------
            //var face_IdCard_Name = new IDCardOCR("../../../Images/ID-Face.jpg", 80 , "arabic_Face_Name_Section", 900, 330 , 1003, 210);
            //// best scale = 80
            //face_IdCard_Name.print_Front_ID_Info(true,true); 


            //-------------------------------------------- [ Id card Face Address =>  ( O ) ] -------------------------------------
            var face_IdCard_Address = new IDCardOCR("../../../Images/ID-Face.jpg", 200, "arabic_Face_Address_Section", 900, 600, 1003, 100);
            // best scale = 200
            face_IdCard_Address.print_Front_ID_Info(true,default,default,true);


            ////-------------------------------------------- [ Id card Face ID Number =>  Done ( ✔️ ) "You can improve it " ] -------------------------------------
            //var face_IdCard_IDNum = new IDCardOCR("../../../Images/ID-Face.jpg", 75 , "arabic_Face_IDNum_Section", 900, 985, 1003, 100);
            //// best scale = 201
            //face_IdCard_IDNum.print_Front_ID_Info(true, true,true);






            //var back_IdCard = new IDCardOCR("../../../Images/ID-Back.jpg",83, "arabic_Back_rec", 600, 80, 1025, 580);
            ////scale = 63 , 80
            //back_IdCard.print_Back_ID_Info(default,true,true);

        }
    }
}



//using (var ocrInput = new OcrInput("../../../Images/ID-Face.jpg"))
//{
//    //ocrInput.DeNoise();
//    //ocrInput.Despeckle();

//    ocrInput.Erode();
//    //ocrInput.Open();
//    //ocrInput.ToGrayScale();
//    ocrInput.Binarize();
//    //ocrInput.Sharpen();

//    ocrInput.SelectTextColor(Color.Black);
//    var rec = new CropRectangle(900,300,1200,800);
//    //ocrInput.Scale(130);
//    var newImage = ocrInput.StampCropRectangleAndSaveAs(rec,Color.Red);
//    ocrInput.Scale(130);//125

//    var ocrResult = Ocr.Read(ocrInput);

//    Console.WriteLine(ocrResult.Text);
//    Console.WriteLine("-----------------------------------------------------------------------");
//    Console.WriteLine(newImage[0]);
//    ocrResult.SaveAsSearchablePdf("../../../OCR_Result/arabic_Face.pdf");
//    ocrResult.SaveAsTextFile("../../../OCR_Result/arabic_Face.txt");

//}


//using (var ocrInput = new OcrInput("../../../Images/ID-Back.jpg"))
//{
//    ocrInput.DeNoise();
//    //ocrInput.Despeckle();
//    ocrInput.Binarize();
//    ocrInput.Sharpen();
//    ocrInput.Erode();
//    ocrInput.Scale(112,true); //130


//    var ocrResult = Ocr.Read(ocrInput);

//    Console.WriteLine(ocrResult.Text);
//    ocrResult.SaveAsSearchablePdf("../../../OCR_Result/arabic_back.pdf");
//    ocrResult.SaveAsTextFile("../../../OCR_Result/arabic_back.txt");
//    //Check if the file exists

//}
