This is my first webpage ever created using C# and Visual Studio Code. 





Some Notes for myself: C# follows MVVM, which stands for Model-View-ViewModel instead of the conventional for JS, which is M-V-C. Controllers are no longer a thing in C#. 


For RazorPage init. 
dotnet aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovie.Data.RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries --databaseProvider sqlite

-m is the name of the model
-dc  The DbContext class to use including Namespace
-udl   Use default layout
-outDir  The relative output folder path to create the 
views
--referenceScriptLibraries  Adds _ValidationScriptPartial to Edit and Create Pages. 