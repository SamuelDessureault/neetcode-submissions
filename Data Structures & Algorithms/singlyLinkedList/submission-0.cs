public class LinkedList {

    private class Node {
        public int val;
        public Node next;

        public Node(int val) {
            this.val = val;
        }
    }

    private Node head;

    public LinkedList() {

    }

    public int Get(int index) {
        Node node = head;
        for (int i = 0; node != null; i++){
            if (i == index) return node.val;
            node = node.next;
        }
        return -1;
    }

    public void InsertHead(int val) {
        Node newNode = new Node(val);
        newNode.next = head;
        head = newNode;
    }

    public void InsertTail(int val) {
        if (head == null) {
            head = new Node(val);
            return;
        }

        Node node;
        for (node = head; node.next != null; node = node.next) {}

        node.next = new Node(val);
    }

    public bool Remove(int index) {
        if (index < 0 || head == null) return false;

        if (index == 0) {
            head = head.next;
            return true;
        }

        Node prevNode = head;

        for (int i = 0; prevNode.next != null; i++) {
            if (i == index - 1) {
                prevNode.next = prevNode.next.next;
                return true;
            }

            prevNode = prevNode.next;
        }

        return false;
    }

    public List<int> GetValues() {
        List<int> list = new List<int>();

        for (Node node = head; node != null; node = node.next)
        {
            list.Add(node.val);
        }
        return list;
    }
}