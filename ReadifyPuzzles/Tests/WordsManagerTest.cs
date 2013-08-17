using System;
using NUnit.Framework;

namespace ReadifyPuzzles {
	[TestFixture()]
	public class WordsManagerTest {

		[Test()]
		public void CornersTestCase () {
			String modifiedString = WordsManager.GetReversedWordsInString ("");

			Assert.AreEqual ("", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString (" ");
			
			Assert.AreEqual (" ", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("   ");
			
			Assert.AreEqual ("   ", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("a");
			
			Assert.AreEqual ("a", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString (" a");
			
			Assert.AreEqual (" a", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("a ");
			
			Assert.AreEqual ("a ", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString (" a ");
			
			Assert.AreEqual (" a ", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString (".");
			
			Assert.AreEqual (".", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString (" . ");
			
			Assert.AreEqual (" . ", modifiedString);
		}

		[Test()]
		public void SimpleTestCase () {
			String modifiedString = WordsManager.GetReversedWordsInString ("a");
			
			Assert.AreEqual ("a", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("ab");
			
			Assert.AreEqual ("ba", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("abc");
			
			Assert.AreEqual ("cba", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("abcd");
			
			Assert.AreEqual ("dcba", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("abcde");
			
			Assert.AreEqual ("edcba", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString (" a ");
			
			Assert.AreEqual (" a ", modifiedString);
			
			modifiedString = WordsManager.GetReversedWordsInString (" ab ");
			
			Assert.AreEqual (" ba ", modifiedString);
			
			modifiedString = WordsManager.GetReversedWordsInString (" abc ");
			
			Assert.AreEqual (" cba ", modifiedString);
			
			modifiedString = WordsManager.GetReversedWordsInString (" abcd ");
			
			Assert.AreEqual (" dcba ", modifiedString);
			
			modifiedString = WordsManager.GetReversedWordsInString (" abcde ");
			
			Assert.AreEqual (" edcba ", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("   abcde   ");
			
			Assert.AreEqual ("   edcba   ", modifiedString);
		}

		[Test()]
		public void ComplexTestCase () {
			String modifiedString = WordsManager.GetReversedWordsInString ("abc klmn xyz");
			
			Assert.AreEqual ("cba nmlk zyx", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString (" abc   klmn   xyz ");
			
			Assert.AreEqual (" cba   nmlk   zyx ", modifiedString);

			modifiedString = WordsManager.GetReversedWordsInString ("abc# klmn xyz.");
			
			Assert.AreEqual ("#cba nmlk .zyx", modifiedString);
		}
	}
}

