namespace Vezel.Ruptura.Memory.Code;

sealed class CodeDisassembler
{
    readonly Iced.Intel.Decoder _decoder;

    public CodeDisassembler(CodeReader reader, nuint ip)
    {
        _decoder = Iced.Intel.Decoder.Create(Environment.Is64BitProcess ? 64 : 32, reader, ip);
    }

    public void Disassemble(out Instruction instruction)
    {
        _decoder.Decode(out instruction);
    }
}
