//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ..\Grammar\Expression.g4 by ANTLR 4.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace GillSoft.ExpressionEvaluator {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="ExpressionParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public interface IExpressionVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpression([NotNull] ExpressionParser.ExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.mathematicalExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMathematicalExpression([NotNull] ExpressionParser.MathematicalExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.booleanExprerssion"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBooleanExprerssion([NotNull] ExpressionParser.BooleanExprerssionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.subExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSubExpression([NotNull] ExpressionParser.SubExpressionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] ExpressionParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.stringValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStringValue([NotNull] ExpressionParser.StringValueContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="ExpressionParser.simpleValue"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSimpleValue([NotNull] ExpressionParser.SimpleValueContext context);
}
} // namespace GillSoft.ExpressionEvaluator
