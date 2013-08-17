/************************************************************************************

 Reverse Words:
 
 Write a function to reverse the words in a string, 
 for example “cat and dog” becomes “tac dna god”.

 Do not use any string manipulation functions that you do not implement yourself.
 
*************************************************************************************/

using System;

namespace ReadifyPuzzles {
	public static class WordsManager {
		public static String GetReversedWordsInString (String phrase) {
		
			// Create destination chars array
			char [] modifiedPhrase = phrase.ToCharArray ();

			// Corner cases
			if ((phrase == null) || (phrase.Length <= 1)) {
				return phrase;
			}

			int wordBeginIndex = 0;
			int wordEndIndex = 0;

			// Parse original phrase
			while (wordBeginIndex < phrase.Length - 1) {

				// Trim beginning spaces 
				while ((wordBeginIndex < phrase.Length) && (modifiedPhrase [wordBeginIndex] == ' ')) {
					wordBeginIndex ++;
				}

				wordEndIndex = wordBeginIndex;

				// Try to find end of the next word
				while ((wordEndIndex < phrase.Length) && (modifiedPhrase [wordEndIndex] != ' ')) {
					wordEndIndex ++;
				}

				// Take care about last char
				wordEndIndex--;

				int wordLength = (wordEndIndex + 1) - wordBeginIndex;

				// Swap word's chars
				for (int i = 0; i < wordLength / 2; i++) {
					char tmpChar = modifiedPhrase [wordBeginIndex + i];

					modifiedPhrase [wordBeginIndex + i] = modifiedPhrase [wordEndIndex - i];
					modifiedPhrase [wordEndIndex - i] = tmpChar;
				}

				// Increase current char's position
				wordBeginIndex += wordLength;
			}

			return new String (modifiedPhrase);
		}
	}
}

