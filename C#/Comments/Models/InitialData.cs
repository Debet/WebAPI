namespace Comments.Models
{
    public class InitialData : DictionaryCommentRepository
    {

        

        public InitialData()
        {
            Add(new Comment
            {
                ID = 1,
                Text = @" This WebAPI SourceCode can be Forked from the Social-site :-)",
                Author = "Jalal",
                Email = "Jalal.Hejazi@gmail.com",
            });

            Add(new Comment
            {
                ID = 2,
                Text = @"One of the coolest features in Visual Studio 2012 is the ability to login using your Microsoft, Facebook, Twitter or Google account. The project templates showcase a social way of logging in along with the usual way of logging in by creating a local account",
                Author = "Jalal",
                Email = "Jalal.Hejazi@gmail.com",
            });
        
            Add(new Comment
            {
                ID = 3,
                Text = "This is the best thing I've ever seen! And trust me, I've seen a lot. A whole lot.",
                Author = "Henrik",
                Email = "henrikn@microsoft.com"
            });
            Add(new Comment
            {
                ID = 4,
                Text = "Is this thing on? Because if it isn't on, we should really consider turning it on. Have you tried turning it on? I haven't. But you should consider it.",
                Author = "Eilon",
                Email = "elipton@microsoft.com"
            });
            Add(new Comment
            {
                ID = 5,
                Text = "My computer's cupholder doesn't work, can you help? I tried calling tech support, but they keep laughing and I don't understand why. It's really not helpful.",
                Author = "Glenn",
                Email = "gblock@microsoft.com"
            });
        }
    }
}