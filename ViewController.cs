using System;

using AppKit;
using Foundation;

using MongoDB.Bson;
using MongoDB.Driver;


namespace LMDB
{
    public partial class ViewController : NSViewController
    {
        private int numberOfTimesClicked = 0;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            
            // Initial setup
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    partial void SubmitButton(Foundation.NSObject sender)
    {
        var settings = MongoClientSettings.FromConnectionString("mongodb+srv://DataAdmin:g4uSbUtzs8b4eAOM@cluster0.t22yp.mongodb.net/myFirstDatabase?retryWrites=true&w=majority");
        var client = new MongoClient(settings);

        var database = client.GetDatabase("Library");
        var collection = database.GetCollection<BsonDocument>("Books");


        var document = new BsonDocument
        {
            {"FID", collection.CountDocuments(new BsonDocument())},
            {"Title", TitleInput.StringValue},
            {"Author", AuthorInput.StringValue},
            {"Genre", GenreInput.StringValue},
            {"ISBN", ISBNInput.StringValue},
            {"Location", LocationInput.StringValue}
        };

        collection.InsertOne(document);

        TitleInput.StringValue = "";
        AuthorInput.StringValue = "";
        GenreInput.StringValue = "";
        ISBNInput.StringValue = "";
        LocationInput.StringValue = "";
    }
    }
}
