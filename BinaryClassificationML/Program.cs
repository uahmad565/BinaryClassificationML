//Load sample data
using BinaryClassificationML;

var sampleData = new MLModel1.ModelInput()
{
    Col0 = @"Crust is good.",
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);
Console.WriteLine(result.ToString());
