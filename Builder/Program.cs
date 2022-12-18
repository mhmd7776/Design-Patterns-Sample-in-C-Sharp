using Builder;

var presentation = new Presentation();

presentation.AddSlide(new Slide("Asp.net Core"));
presentation.AddSlide(new Slide("Django"));
presentation.AddSlide(new Slide("PHP"));
presentation.AddSlide(new Slide("React"));
presentation.AddSlide(new Slide("Angular"));

var builder = new PdfDocumentBuilder();
presentation.Export(builder);
var exportedDocument = builder.GetExportedPdfDocument();

Console.WriteLine("--------------------------------------------------");

var movieBuilder = new MovieBuilder();
presentation.Export(movieBuilder);
var exportedMovie = movieBuilder.GetExportedMovie();