public class Solution {
    public string PredictPartyVictory(string senate) {
        
        // Count the number of each type of Senator to determine the winner
        int rCount = senate.Count(c => c == 'R');
        int dCount = senate.Length - rCount;

        // Ban the candidate "toBan", immediate next to "startAt"
        // If have to loop around, then it means next turn will be of
        // senator at same index. Returns loop around boolean
        bool ban(char toBan, int startAt) {
            bool loopAround = false;
            int pointer = startAt;

            while (pointer < senate.Length) {
                if (pointer == 0) {
                    loopAround = true;
                }
                if (senate[pointer] == toBan) {
                    senate = senate.Remove(pointer, 1);
                    break;
                }
                pointer = (pointer + 1) % senate.Length;
            }

            return loopAround;
        }

        // Set the index of the current senator
        int currentIndex = 0;

        // Simulate the battle until a winner emerges
        while (rCount > 0 && dCount > 0) {

            // Check if current senator is a member of Radiant
            if (senate[currentIndex] == 'R') {
                bool bannedSenatorBefore = ban('D', (currentIndex + 1) % senate.Length);
                dCount--;
                if (bannedSenatorBefore) {
                    currentIndex--;
                }
            } 
            // Current senator is a member of Dire
            else {
                bool bannedSenatorBefore = ban('R', (currentIndex + 1) % senate.Length);
                rCount--;
                if (bannedSenatorBefore) {
                    currentIndex--;
                }
            }

            // Move on to the next senator
            currentIndex = (currentIndex + 1) % senate.Length;
        }

        // Determine and return the winner
        return dCount == 0 ? "Radiant" : "Dire";
    }
}
