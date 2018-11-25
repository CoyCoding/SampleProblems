/*
I just Grouped all the Linked List Questions in one file because they are pretty easy.
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


    static void printLinkedList(SinglyLinkedListNode head) {
        var currentNode = head;
        while(currentNode != null){
            Console.WriteLine(currentNode.data);
            currentNode = currentNode.next;
        }

    }

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
