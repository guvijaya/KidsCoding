# Get vootes till we get 20 votes
# List of contestant
# Show result

def PrintVotingPallette():
    print("")
    print("--------------------------------------")
    print("| Enter the candidate number to vote: |")
    print("| 1. Swetha                           |")
    print("| 2. Shreya                           |")
    print("| 3. Vishal                           |")
    print("| 4. Lalith                           |")
    print("|                                     |")
    print("| Enter your vote                     |")
    print("--------------------------------------")
    vote = int(input())

    if(vote < 0 or vote > 4):
        print("Invalid vote. Try again")
        PrintVotingPallette()

    return vote

SwethaVoteCount = 0
ShreyaVoteCount = 0
VishalVoteCount = 0
LalithVoteCount = 0
NotoVoteCount = 0

for i in range(1,21):
    vote = PrintVotingPallette()

    if(vote == 0):
        NotoVoteCount = NotoVoteCount + 1
    elif vote == 1:
        SwethaVoteCount += 1
    elif vote == 2:
        ShreyaVoteCount += 1
    elif vote == 3:
        VishalVoteCount += 1
    elif vote == 4:
        LalithVoteCount += 1

print("Voting result")
print("Noto Vote: %d" %NotoVoteCount )
print("Swetha Votes: %d" %SwethaVoteCount)
print("Shreya Votes: %d" %ShreyaVoteCount)
print("Lalith Votes: %d" %LalithVoteCount)
print("Vishal Votes: %d" %VishalVoteCount)