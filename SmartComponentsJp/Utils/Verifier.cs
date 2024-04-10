using System.Diagnostics.CodeAnalysis;

namespace SmartComponentsJp.Utils;

public static class Verifier
{
    public static void Verify(
        [NotNull] object? value) =>
        ArgumentNullException.ThrowIfNull(value);
}
