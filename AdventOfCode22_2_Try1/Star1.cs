namespace AdventOfCode22_2_Try1;

internal static class Star1
{
    public static int Run()
    {
        var cheatSheet = File.ReadAllText("Input/input.txt");
        var games = cheatSheet.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
        var totalScore = 0;

        foreach (var game in games)
        {
            var enemyHand = game[0];
            var myHand = game[2];

            switch (myHand)
            {
                case 'X':
                    {
                        totalScore += 1;

                        switch (enemyHand)
                        {
                            case 'A':
                                {
                                    totalScore += 3;
                                    break;
                                }
                            case 'B':
                                {
                                    // remains 0
                                    break;
                                }
                            case 'C':
                                {
                                    totalScore += 6;
                                    break;
                                }
                        }

                        break;
                    }
                case 'Y':
                    {
                        totalScore += 2;

                        switch (enemyHand)
                        {
                            case 'A':
                                {
                                    totalScore += 6;
                                    break;
                                }
                            case 'B':
                                {
                                    totalScore += 3;

                                    break;
                                }
                            case 'C':
                                {
                                    // remains 0
                                    break;
                                }
                        }

                        break;
                    }
                case 'Z':
                    {
                        totalScore += 3;

                        switch (enemyHand)
                        {
                            case 'A':
                                {
                                    // remains 0
                                    break;
                                }
                            case 'B':
                                {
                                    totalScore += 6;
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
            }
        }

        return totalScore;
    }
}