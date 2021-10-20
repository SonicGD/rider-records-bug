using RiderBugPackage;

var consumerAbstractInheritedBugRecord = new ConsumerAbstractInheritedBugRecord();
Console.WriteLine(consumerAbstractInheritedBugRecord);

public record ConsumerAbstractBugRecord : AbstractBugRecord
{
}

public record ConsumerAbstractInheritedBugRecord : AbstractInheritedBugRecord
{
}

public record ConsumerBugRecord : BugRecord
{
}

public record ConsumerInheritedBugRecord : InheritedBugRecord
{
}

public record ConsumerInheritedFromAbstractBugRecord : InheritedFromAbstractBugRecord
{
}

public record ConsumerAbstractInheritedFromNonAbstractBugRecord : AbstractInheritedFromNonAbstractBugRecord
{
}