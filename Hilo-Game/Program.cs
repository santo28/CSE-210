// See https://aka.ms/new-console-template for more information
namespace hilo_game
{
    class Program{
        ///Begins game
        static int Main(string[] args){
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}