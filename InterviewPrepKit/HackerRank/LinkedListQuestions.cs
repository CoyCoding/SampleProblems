/*
I just Grouped all the Linked List Questions in one file because they are pretty easy.




For your reference:
     
    SinglyLinkedListNode 
    {
         int data;
         SinglyLinkedListNode next;
    }
   
*/


/*
     
                                   Insert   Node   At     Tail 
     
 */



    static SinglyLinkedListNode insertNodeAtTail(SinglyLinkedListNode head, int data) {
        if(head == null){
            head = new SinglyLinkedListNode(data);
            return head;
        }
        
        var tempHead = head;
        while(tempHead.next != null){
            tempHead = tempHead.next;
        }
            tempHead.next = new SinglyLinkedListNode(data);
        
        return head;
    }



/*

                                   Print      Nodes

*/

    static void printLinkedList(SinglyLinkedListNode head) {
        var currentNode = head;
        while(currentNode != null){
            Console.WriteLine(currentNode.data);
            currentNode = currentNode.next;
        }

    }

/*
     
                                   Insert   Node   At Position 
     
*/

    static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position) {
            var tempNode = new SinglyLinkedListNode(data);
            var currentNode = head;

            if(head == null)
            {
                return tempNode;
            }
            if(position == 0)
            {
                tempNode.next = head;
                return tempNode;
            }

            for(int i = 0; i < position - 1; i++)
            {
                currentNode = currentNode.next;
            }

            tempNode.next = currentNode.next;
            currentNode.next = tempNode; 

            
            return head;
    }

/*
     
                                   Delete   Node    
     
 */

static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {
        if(position == 0 )
        {
            head = head.next;
            return head;
        }

        var removalNode = head.next;
        var parentNode = head;

        for(int i = 1; i < position; i++){
            parentNode = parentNode.next;
            removalNode = removalNode.next;
        }

        parentNode.next = removalNode.next;
        return head;
    }


/*
     
                                   Delete   Node  Recursion  
     
 */

    static SinglyLinkedListNode deleteNode(SinglyLinkedListNode head, int position) {
        if(position == 0 )
        {
            return head.next;
        }
        
        head.next = deleteNode(head.next, position-1);
        return head;
    }


/*
     
                                   Reverse Print  
     
 */



    static void reversePrint(SinglyLinkedListNode head) {
        List<int> printList = new List<int>();
        var currentNode = head;

        while (currentNode != null)
        {
            printList.Add(currentNode.data);
            currentNode = currentNode.next;
        }
        
        for(int i = printList.Count-1; i >= 0; i--){           
            Console.WriteLine(printList[i]);
        }
    }


/*
     
                                   Reverse  
     
 */



    static SinglyLinkedListNode reverse(SinglyLinkedListNode head) {

        if (head == null || head.next == null) {  
            return head;  
        }

        SinglyLinkedListNode remaining = reverse(head.next);

        head.next.next = head; 

        head.next = null;  

        return remaining; 
    }


/*   

                                  Insert At Head                                                         
     
*/


     static SinglyLinkedListNode insertNodeAtHead(SinglyLinkedListNode head, int data) {
          var newHead = new SinglyLinkedListNode(data);
          if (head == null) 
          {
          return newHead;
          }
          
          newHead.next = head;
          return newHead;

    }


/*   

                                  Compare two Linked Lists                                                         
     
*/


   static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        if(head1 == null && head2 == null){
            return true;
        }

        if(head1 == null || head2 == null){
            return false;
        }
        
        if(head1.data == head2.data){
            return CompareLists(head1.next, head2.next);
        }else{
            return false;
        }
        
    }

/*

                    MERGE lINKED LISTS ASC


*/




    static SinglyLinkedListNode mergeLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        if(head1 == null ){
            return head2;
        }
        if(head2 == null){
            return head1;
        }
        if (head1.data >= head2.data) {
            SinglyLinkedListNode temp = head2;
            head2 = head2.next;
            temp.next = head1;
            head1 = temp;
            head1.next = mergeLists(head1.next, head2);
        } else {
            head1.next = mergeLists(head1.next, head2);
        }
        return head1;       
    }

/*

                                        Get Node based on distance from tail

*/



    static int getNode(SinglyLinkedListNode head, int positionFromTail){
        var targetNode = head;
        var listIterator = head;

        for(int i= 0; i < positionFromTail; i++)
        {
            listIterator = listIterator.next;
        }

        while(listIterator.next != null)
        {
            listIterator = listIterator.next;
            targetNode = targetNode.next;
        }

        return targetNode.data; 
    }


/*

                    Remove Duplcates from sorted Linked List

*/





    static SinglyLinkedListNode removeDuplicates(SinglyLinkedListNode head) {
        if(head==null)
        {
            return null;
        } 

        while ( head.next != null && head.data == head.next.data ) 
        {
            head.next=head.next.next;
        }

        removeDuplicates(head.next);

        return head;
    }

/*

                    Check Linked List for Duplicate Nodes

*/


    static bool hasCycle(SinglyLinkedListNode head) {
        if(head == null)
        {
            return false;
        }
       var nodeList = new HashSet<SinglyLinkedListNode>();

        while(head != null){
            if(nodeList.Contains(head))
            {
                return true;
            }else
            {
                nodeList.Add(head);
            }
            head = head.next;
        }


       return false;

    }
/*

               Find The Data Value of the Merge Node

*/


    static int findMergeNode(SinglyLinkedListNode head1, SinglyLinkedListNode head2) {
        HashSet<SinglyLinkedListNode> nodeTracker = new HashSet<SinglyLinkedListNode>();
        while(head1 != null)
        {
            nodeTracker.Add(head1);
            head1 = head1.next;
        }
        while(!nodeTracker.Contains(head2)){
            head2 = head2.next;
        }
        return head2.data;
    }
