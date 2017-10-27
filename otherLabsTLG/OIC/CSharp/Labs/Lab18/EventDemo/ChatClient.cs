// ChatClient.cs - Step 0

using System;

class ChatClient
{
	// TO DO:
	// Add event handlers for joining and quitting
	// Display the sender and the name of person
    public static void Join(object sender, ChatEventArg e)
    {
        Console.WriteLine(
            "sender = {0}, {1} has joined the chat", sender, e.Name);
    }
    public static void Quit(object sender, ChatEventArg e)
    {
        Console.WriteLine(
            "sender = {0}, {1} has quitted the chat", sender, e.Name);
    }

    public static void Main()
	{
		ChatServer chat = new ChatServer();
        // Register to receive event notifications from the server

        // TO DO:
        // Add code to register your event handlers
        chat.Join += new JoinHandler(Join);
        chat.Quit += new QuitHandler(Quit);
		// Call methods on the server
		chat.JoinChat("Michael");
		chat.JoinChat("Bob");
		chat.JoinChat("Sam");
		chat.ShowMembers("After 3 have joined");
		chat.QuitChat("Bob");
		chat.ShowMembers("After 1 has quit");
	}
}