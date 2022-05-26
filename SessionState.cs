namespace EnumToString;

public enum SessionState
{
    STARTED,
    STOPPED,
}

public static class SessionStateExtensions
{
    public static string AsString(this SessionState state)
    {
        return state switch
        {
            SessionState.STARTED => nameof(SessionState.STARTED),
            SessionState.STOPPED => nameof(SessionState.STOPPED),
            _ => throw new ArgumentOutOfRangeException(nameof(state), state, null),
        };
    }
}