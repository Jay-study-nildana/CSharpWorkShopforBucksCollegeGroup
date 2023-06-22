// See https://aka.ms/new-console-template for more information
using ClassesandObjects;

Console.WriteLine("Hello, World!");

Movie firstmovie = new Movie();

firstmovie.MovieTitle = "The Flash";
firstmovie.MovieReleaseStatus = true;
firstmovie.MovieReleaseYear = 2023;

string firstmoviestuff = $"The name of the movie is {firstmovie.MovieTitle} and it is being released in {firstmovie.MovieReleaseYear} and current status of releasing is {firstmovie.MovieReleaseStatus}";

Console.WriteLine(firstmoviestuff);



Movie secondmovie = new Movie();

secondmovie.MovieTitle = "Elemental";
secondmovie.MovieReleaseStatus = false;
secondmovie.MovieReleaseYear = 2023;

string secondmoviestuff = $"The name of the movie is {secondmovie.MovieTitle} and it is being released in {secondmovie.MovieReleaseYear} and current status of releasing is {secondmovie.MovieReleaseStatus}";

Console.WriteLine(secondmoviestuff);

Movie thirdmovie = new Movie();
thirdmovie.MovieTitle = "Indiana Jones and the Dial of Destiny";
thirdmovie.MovieReleaseStatus = false;
thirdmovie.MovieReleaseYear = 2023;

string thirdmoviestuff = $"The name of the movie is {thirdmovie.MovieTitle} and it is being released in {thirdmovie.MovieReleaseYear} and current status of releasing is {thirdmovie.MovieReleaseStatus}";

Console.WriteLine(thirdmoviestuff);


//lets create a video game object with MineCraft 

VideoGame firstvideogame = new VideoGame();

firstvideogame.NameOfVideoGame = "MineCraft";
firstvideogame.TypeOfGame = "Online Educational Multiplayer Sandbox";
firstvideogame.TypeOfGamingDevice = "iPhone, iPad, Xbox, PS, PC, Android";
firstvideogame.GameReleaseYear = 2011;

string firstvideogameoutput = $"name : {firstvideogame.NameOfVideoGame} type of videogame : {firstvideogame.TypeOfGame} where can you play it : {firstvideogame.TypeOfGamingDevice} release year : {firstvideogame.GameReleaseYear}";

Console.WriteLine(firstvideogameoutput);