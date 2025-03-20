/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head=new ListNode(-1);
        ListNode tempNode=head;
        int sum=0;
        int rem=0;
        while(l1 != null || l2 !=null || rem>0){
            int l1Val=0;
            int l2Val=0;

            if(l1 != null){
                l1Val=l1.val;
                l1=l1.next;
            
            }
            if(l2 != null){
                l2Val=l2.val;
                l2=l2.next;
            
            }

            sum=l1Val+l2Val+rem;
            int nodeVal = sum%10;
            rem=sum/10;

            tempNode.next=new ListNode(nodeVal);
            tempNode=tempNode.next;
        }
        return head.next;
    }
}