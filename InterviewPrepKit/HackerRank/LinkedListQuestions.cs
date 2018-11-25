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

