/************************************************************************************

 Linked list:
 
 Write a function that would return the 5th element from the tail (or end) of a 
 singly linked list of integers.
 Should return the 5th element from the tail in a single pass.
 Should be your own code and should not use any built-in .NET collection components.

 For example, given the list 2 -> 3 -> 4 ->5 -> 6 -> 7 -> 8 -> 9 -> 10 -> 11 your 
 function would return 7.
 
*************************************************************************************/
using System;

namespace ReadifyPuzzles {
	public static class ListManager {

		public static ListNode GetKthLastNodeOfTheList (ListNode linkedList, int k) {
			int currentNodeIndex = 0;

			// Store list head pointer
			ListNode kthNode = linkedList;

			// Corner case
			if (linkedList == null) {
				return null;
			}

			// Skip first k nodes
			while ((currentNodeIndex < k) && (linkedList != null)) {
				linkedList = linkedList.GetNextNode();
				currentNodeIndex ++;
			}

			// No more nodes left in the list
			if (linkedList == null) {
				return null;
			}

			// Continue to iterate both pointers to the end of the list
			while (linkedList != null) {
				kthNode = kthNode.GetNextNode ();
				linkedList = linkedList.GetNextNode ();
			}

			return kthNode;
		}

		public static ListNode GetFifthLastNodeOfTheList (ListNode linkedList) {

			// Return 5th last node from the end of the list
			return ListManager.GetKthLastNodeOfTheList (linkedList, 5);
		}
	}
}

