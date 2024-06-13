public class Solution {
 public int MinMovesToSeat(int[] seats, int[] students) => seats.OrderBy(m => m)
        .Zip(students.OrderBy(m => m), (seat, student) => new {seat, student})
        .Sum(m => Math.Abs(m.seat - m.student));
}