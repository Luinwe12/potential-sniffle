namespace KnowledgeCheckTwo
{
    internal static class GamesprivateHelpers
    {

        public static object GetDebuggerDisplay1 => GetDebuggerDisplay;

        public static object GetDebuggerDisplay { get; private set; }
    }
}