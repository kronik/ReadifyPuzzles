/************************************************************************************
 * Simple single linked list node
*************************************************************************************/

using System;
using System.Diagnostics;

namespace ReadifyPuzzles {
	public class ListNode {

		private int data;
		private ListNode nextNode;

		public ListNode () {
			this.data = 0;
			this.nextNode = null;
		}

		public ListNode (int data, ListNode nextNode) {
			this.data = data;
			this.nextNode = nextNode;
		}

		public ListNode GetNextNode () {
			return this.nextNode;
		}

		public int GetData () {
			return this.data;
		}

		public void Print () {
			ListNode currentNode = this;

			while (currentNode != null) {
				Console.Write (currentNode.data + "->");

				currentNode = currentNode.GetNextNode ();
			}

			Console.Write ("null\n");
		}
	}
}

