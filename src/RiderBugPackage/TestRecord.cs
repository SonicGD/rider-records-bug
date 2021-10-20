namespace RiderBugPackage;

public abstract record AbstractBugRecord
{
}

public abstract record AbstractInheritedBugRecord : AbstractBugRecord
{
}

public record BugRecord
{
}

public record InheritedBugRecord : BugRecord
{
}

public record InheritedFromAbstractBugRecord : AbstractBugRecord
{
}

public abstract record AbstractInheritedFromNonAbstractBugRecord : BugRecord
{
}