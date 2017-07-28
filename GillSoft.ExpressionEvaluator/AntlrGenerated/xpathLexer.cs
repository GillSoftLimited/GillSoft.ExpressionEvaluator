//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ..\Grammar\xpath.g4 by ANTLR 4.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace GillSoft.ExpressionEvaluator {
using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public partial class xpathLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		INTEGER=1, DECIMAL=2, IDENT=3, PATHSEP=4, ABRPATH=5, LPAR=6, RPAR=7, LBRAC=8, 
		RBRAC=9, MINUS=10, PLUS=11, DOT=12, MUL=13, DOTDOT=14, AT=15, COMMA=16, 
		PIPE=17, LESS=18, MORE_=19, EQ=20, LE=21, GE=22, COLON=23, CC=24, APOS=25, 
		QUOT=26, STRING=27, Whitespace=28;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"INTEGER", "DECIMAL", "IDENT", "PATHSEP", "ABRPATH", "LPAR", "RPAR", "LBRAC", 
		"RBRAC", "MINUS", "PLUS", "DOT", "MUL", "DOTDOT", "AT", "COMMA", "PIPE", 
		"LESS", "MORE_", "EQ", "LE", "GE", "COLON", "CC", "APOS", "QUOT", "STRING", 
		"Whitespace"
	};


	public xpathLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, null, null, null, "'/'", "'//'", "'('", "')'", "'['", "']'", "'-'", 
		"'+'", "'.'", "'*'", "'..'", "'@'", "','", "'|'", "'<'", "'>'", null, 
		"'<='", "'>='", "':'", "'::'", "'''", "'\"'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "INTEGER", "DECIMAL", "IDENT", "PATHSEP", "ABRPATH", "LPAR", "RPAR", 
		"LBRAC", "RBRAC", "MINUS", "PLUS", "DOT", "MUL", "DOTDOT", "AT", "COMMA", 
		"PIPE", "LESS", "MORE_", "EQ", "LE", "GE", "COLON", "CC", "APOS", "QUOT", 
		"STRING", "Whitespace"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "xpath.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	static xpathLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x1E");
		sb.Append("\xA1\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6");
		sb.Append("\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f");
		sb.Append("\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4");
		sb.Append("\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16");
		sb.Append("\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B");
		sb.Append("\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x3\x2\x6\x2=\n\x2\r\x2\xE\x2");
		sb.Append(">\x3\x3\x6\x3\x42\n\x3\r\x3\xE\x3\x43\x3\x3\x3\x3\x6\x3H\n\x3");
		sb.Append("\r\x3\xE\x3I\x3\x4\x3\x4\a\x4N\n\x4\f\x4\xE\x4Q\v\x4\x3\x5\x3");
		sb.Append("\x5\x3\x6\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\n\x3");
		sb.Append("\n\x3\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3");
		sb.Append("\xF\x3\x10\x3\x10\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13\x3\x13");
		sb.Append("\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x5\x15x\n\x15\x3\x16\x3");
		sb.Append("\x16\x3\x16\x3\x17\x3\x17\x3\x17\x3\x18\x3\x18\x3\x19\x3\x19");
		sb.Append("\x3\x19\x3\x1A\x3\x1A\x3\x1B\x3\x1B\x3\x1C\x3\x1C\a\x1C\x8B");
		sb.Append("\n\x1C\f\x1C\xE\x1C\x8E\v\x1C\x3\x1C\x3\x1C\x3\x1C\a\x1C\x93");
		sb.Append("\n\x1C\f\x1C\xE\x1C\x96\v\x1C\x3\x1C\x5\x1C\x99\n\x1C\x3\x1D");
		sb.Append("\x6\x1D\x9C\n\x1D\r\x1D\xE\x1D\x9D\x3\x1D\x3\x1D\x2\x2\x1E\x3");
		sb.Append("\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19");
		sb.Append("\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x14\'\x15)\x16+\x17-\x18");
		sb.Append("/\x19\x31\x1A\x33\x1B\x35\x1C\x37\x1D\x39\x1E\x3\x2\b\x3\x2");
		sb.Append("\x32;\x6\x2%%\x43\\\x61\x61\x63|\b\x2%%\x30\x30\x32;\x43\\\x61");
		sb.Append("\x61\x63|\x3\x2$$\x3\x2))\x5\x2\v\f\xF\xF\"\"\xA9\x2\x3\x3\x2");
		sb.Append("\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2");
		sb.Append("\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3");
		sb.Append("\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2");
		sb.Append("\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2");
		sb.Append("\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2%\x3");
		sb.Append("\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+\x3\x2\x2\x2\x2");
		sb.Append("-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2");
		sb.Append("\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2");
		sb.Append("\x2\x3<\x3\x2\x2\x2\x5\x41\x3\x2\x2\x2\aK\x3\x2\x2\x2\tR\x3");
		sb.Append("\x2\x2\x2\vT\x3\x2\x2\x2\rW\x3\x2\x2\x2\xFY\x3\x2\x2\x2\x11");
		sb.Append("[\x3\x2\x2\x2\x13]\x3\x2\x2\x2\x15_\x3\x2\x2\x2\x17\x61\x3\x2");
		sb.Append("\x2\x2\x19\x63\x3\x2\x2\x2\x1B\x65\x3\x2\x2\x2\x1Dg\x3\x2\x2");
		sb.Append("\x2\x1Fj\x3\x2\x2\x2!l\x3\x2\x2\x2#n\x3\x2\x2\x2%p\x3\x2\x2");
		sb.Append("\x2\'r\x3\x2\x2\x2)w\x3\x2\x2\x2+y\x3\x2\x2\x2-|\x3\x2\x2\x2");
		sb.Append("/\x7F\x3\x2\x2\x2\x31\x81\x3\x2\x2\x2\x33\x84\x3\x2\x2\x2\x35");
		sb.Append("\x86\x3\x2\x2\x2\x37\x98\x3\x2\x2\x2\x39\x9B\x3\x2\x2\x2;=\t");
		sb.Append("\x2\x2\x2<;\x3\x2\x2\x2=>\x3\x2\x2\x2><\x3\x2\x2\x2>?\x3\x2");
		sb.Append("\x2\x2?\x4\x3\x2\x2\x2@\x42\t\x2\x2\x2\x41@\x3\x2\x2\x2\x42");
		sb.Append("\x43\x3\x2\x2\x2\x43\x41\x3\x2\x2\x2\x43\x44\x3\x2\x2\x2\x44");
		sb.Append("\x45\x3\x2\x2\x2\x45G\a\x30\x2\x2\x46H\t\x2\x2\x2G\x46\x3\x2");
		sb.Append("\x2\x2HI\x3\x2\x2\x2IG\x3\x2\x2\x2IJ\x3\x2\x2\x2J\x6\x3\x2\x2");
		sb.Append("\x2KO\t\x3\x2\x2LN\t\x4\x2\x2ML\x3\x2\x2\x2NQ\x3\x2\x2\x2OM");
		sb.Append("\x3\x2\x2\x2OP\x3\x2\x2\x2P\b\x3\x2\x2\x2QO\x3\x2\x2\x2RS\a");
		sb.Append("\x31\x2\x2S\n\x3\x2\x2\x2TU\a\x31\x2\x2UV\a\x31\x2\x2V\f\x3");
		sb.Append("\x2\x2\x2WX\a*\x2\x2X\xE\x3\x2\x2\x2YZ\a+\x2\x2Z\x10\x3\x2\x2");
		sb.Append("\x2[\\\a]\x2\x2\\\x12\x3\x2\x2\x2]^\a_\x2\x2^\x14\x3\x2\x2\x2");
		sb.Append("_`\a/\x2\x2`\x16\x3\x2\x2\x2\x61\x62\a-\x2\x2\x62\x18\x3\x2");
		sb.Append("\x2\x2\x63\x64\a\x30\x2\x2\x64\x1A\x3\x2\x2\x2\x65\x66\a,\x2");
		sb.Append("\x2\x66\x1C\x3\x2\x2\x2gh\a\x30\x2\x2hi\a\x30\x2\x2i\x1E\x3");
		sb.Append("\x2\x2\x2jk\a\x42\x2\x2k \x3\x2\x2\x2lm\a.\x2\x2m\"\x3\x2\x2");
		sb.Append("\x2no\a~\x2\x2o$\x3\x2\x2\x2pq\a>\x2\x2q&\x3\x2\x2\x2rs\a@\x2");
		sb.Append("\x2s(\x3\x2\x2\x2tu\a?\x2\x2ux\a?\x2\x2vx\a?\x2\x2wt\x3\x2\x2");
		sb.Append("\x2wv\x3\x2\x2\x2x*\x3\x2\x2\x2yz\a>\x2\x2z{\a?\x2\x2{,\x3\x2");
		sb.Append("\x2\x2|}\a@\x2\x2}~\a?\x2\x2~.\x3\x2\x2\x2\x7F\x80\a<\x2\x2");
		sb.Append("\x80\x30\x3\x2\x2\x2\x81\x82\a<\x2\x2\x82\x83\a<\x2\x2\x83\x32");
		sb.Append("\x3\x2\x2\x2\x84\x85\a)\x2\x2\x85\x34\x3\x2\x2\x2\x86\x87\a");
		sb.Append("$\x2\x2\x87\x36\x3\x2\x2\x2\x88\x8C\a$\x2\x2\x89\x8B\n\x5\x2");
		sb.Append("\x2\x8A\x89\x3\x2\x2\x2\x8B\x8E\x3\x2\x2\x2\x8C\x8A\x3\x2\x2");
		sb.Append("\x2\x8C\x8D\x3\x2\x2\x2\x8D\x8F\x3\x2\x2\x2\x8E\x8C\x3\x2\x2");
		sb.Append("\x2\x8F\x99\a$\x2\x2\x90\x94\a)\x2\x2\x91\x93\n\x6\x2\x2\x92");
		sb.Append("\x91\x3\x2\x2\x2\x93\x96\x3\x2\x2\x2\x94\x92\x3\x2\x2\x2\x94");
		sb.Append("\x95\x3\x2\x2\x2\x95\x97\x3\x2\x2\x2\x96\x94\x3\x2\x2\x2\x97");
		sb.Append("\x99\a)\x2\x2\x98\x88\x3\x2\x2\x2\x98\x90\x3\x2\x2\x2\x99\x38");
		sb.Append("\x3\x2\x2\x2\x9A\x9C\t\a\x2\x2\x9B\x9A\x3\x2\x2\x2\x9C\x9D\x3");
		sb.Append("\x2\x2\x2\x9D\x9B\x3\x2\x2\x2\x9D\x9E\x3\x2\x2\x2\x9E\x9F\x3");
		sb.Append("\x2\x2\x2\x9F\xA0\b\x1D\x2\x2\xA0:\x3\x2\x2\x2\f\x2>\x43IOw");
		sb.Append("\x8C\x94\x98\x9D\x3\b\x2\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());


}
} // namespace GillSoft.ExpressionEvaluator