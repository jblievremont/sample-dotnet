/*
 * Copyright (C) 2023 AsteroMitH
 */
namespace NestedSwitch
{
    static class NestedSwitchSample
    {
        public static void SwitchOnBothParameters(int first, int second)
        {
            switch(first)
            {
                case 0:
                    switch(second)
                    {
                        case 0:
                            Console.WriteLine("Both are zero!");
                            break;
                        default:
                            Console.WriteLine("Only first is zero!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("No param is zero!");
                    break;
            }
        }
    }
}
