﻿
// This file was auto-generated by ML.NET Model Builder. 

using System;

namespace ModelClassificationConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelClassification.ModelInput sampleData = new ModelClassification.ModelInput()
            {
                ImageSource = @"D:\Projects\Study\Программирование по фану\ChessClassification\ChessClassification\ChessDataset\Bishop\00000000.JPG",
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ModelClassification.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Label with predicted Label from sample data...\n\n");


            Console.WriteLine($"ImageSource: {@"D:\Projects\Study\Программирование по фану\ChessClassification\ChessClassification\ChessDataset\Bishop\00000000.JPG"}");


            Console.WriteLine($"\n\nPredicted Label value: {predictionResult.Prediction} \nPredicted Label scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}