using System;
using NUnit.Framework;

namespace ReadifyPuzzles {

	[TestFixture ()]
	public class ListManagerTest {

		private ListNode listHead;

		[SetUp]
		public void Setup() {
			for (int i = 10; i >= 0; i--) {
				listHead = new ListNode (i, listHead);
			}
			
			listHead.Print ();
		}

		[TearDown]
		public void TearDown() {
			listHead = null;
		}

		[Test ()]
		public void IntegrityTestCase () {
			Assert.IsNotNull (listHead);
		}

		[Test ()]
		public void FuncionalValidTestCase () {

			int k = 1;

			ListNode kthLastNode = ListManager.GetKthLastNodeOfTheList (listHead, k); 
			
			Assert.AreEqual (10, kthLastNode.GetData ());

			k = 10;

			kthLastNode = ListManager.GetKthLastNodeOfTheList (listHead, k); 
			
			Assert.AreEqual (1, kthLastNode.GetData ());

			k = 5;
			
			kthLastNode = ListManager.GetKthLastNodeOfTheList (listHead, k); 
			
			Assert.AreEqual (6, kthLastNode.GetData ());
		}

		[Test ()]
		public void FuncionalInvalidTestCase () {
			int k = 100;
			
			ListNode kthLastNode = ListManager.GetKthLastNodeOfTheList (listHead, k);  

			Assert.IsNull (kthLastNode);
			
			k = -100;
			
			kthLastNode = ListManager.GetKthLastNodeOfTheList (listHead, k); 
			
			Assert.IsNull (kthLastNode);
		}
	}
}

