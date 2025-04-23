namespace ErrorHandlingAndExceptions;

/*
    💡 Ekstra utfordring (logisk og realistisk!)
        - Lag en egen definert exception-klasse:
 */
public class MaterialUsageException : Exception
{
    public MaterialUsageException(string? message = null)
        : base(message ?? "Det oppstod en feil ved bruk av byggemateriale.")
    {
    }
    
}