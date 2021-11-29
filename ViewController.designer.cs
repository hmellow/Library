// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace LMDB
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField AuthorInput { get; set; }

		[Outlet]
		AppKit.NSTextField GenreInput { get; set; }

		[Outlet]
		AppKit.NSTextField ISBNInput { get; set; }

		[Outlet]
		AppKit.NSTextField LocationInput { get; set; }

		[Outlet]
		AppKit.NSTextField TitleInput { get; set; }

		[Action ("SubmitButton:")]
		partial void SubmitButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (TitleInput != null) {
				TitleInput.Dispose ();
				TitleInput = null;
			}

			if (AuthorInput != null) {
				AuthorInput.Dispose ();
				AuthorInput = null;
			}

			if (GenreInput != null) {
				GenreInput.Dispose ();
				GenreInput = null;
			}

			if (ISBNInput != null) {
				ISBNInput.Dispose ();
				ISBNInput = null;
			}

			if (LocationInput != null) {
				LocationInput.Dispose ();
				LocationInput = null;
			}
		}
	}
}
