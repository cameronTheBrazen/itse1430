// Cameron kingsley
//9/23/2023
//ITSE1430



using Cameron.CharacterCreator;

class Program
{
    static void Main ()
    {
        var app = new Program();
        app.Run();
    }
    void Run ()
    {
        UserInterface userInterface = new Cameron.CharacterCreator.UserInterface();
        userInterface.CreationLoop();
    }
   


}