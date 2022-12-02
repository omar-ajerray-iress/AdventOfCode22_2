namespace AdventOfCode22_2_Try1;

internal static class Star2
{
    public static int Run()
    {
        var cheatSheet = File.ReadAllText("Input/input.txt");
        var games = cheatSheet.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var totalScore = 0;

        foreach (var game in games)
        {
            var enemyHand = game[0];
            var result = game[2];

            switch (result)
            {
                // I lose.
                    case 'X':
                    {
                        // remains 0
                        switch (enemyHand)
                        {
                            case 'A':
                            {
                                totalScore += 3;
                                break;
                            }
                            case 'B':
                            {
                                totalScore += 1;
                                    break;
                            }
                            case 'C':
                            {
                                totalScore += 2;
                                    break;
                            }
                        }
                        break;
                    }
                    case 'Y':
                    {
                        // Draw.
                        totalScore += 3;

                        switch (enemyHand)
                        {
                            case 'A':
                            {
                                    totalScore += 1;
                                    break;
                            }
                            case 'B':
                            {
                                totalScore += 2;
                                
                                break;
                            }
                            case 'C':
                            {
                                totalScore += 3;
                                    break;
                            }
                        }
                        break;
                    }
                    case 'Z':
                    {
                        // I win.
                        totalScore += 6;

                        switch (enemyHand)
                        {
                            case 'A':
                            {
                                totalScore += 2;
                                    break;
                            }
                            case 'B':
                            {
                                totalScore += 3;
                                break;
                            }
                            case 'C':
                            {
                                totalScore += 1;
                                    break;
                            }
                        }
                        break;
                    }
            }
        }
        return totalScore;
    }
}