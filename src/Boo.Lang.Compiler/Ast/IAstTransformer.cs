﻿#region license
// boo - an extensible programming language for the CLI
// Copyright (C) 2004 Rodrigo B. de Oliveira
//
// Permission is hereby granted, free of charge, to any person 
// obtaining a copy of this software and associated documentation 
// files (the "Software"), to deal in the Software without restriction, 
// including without limitation the rights to use, copy, modify, merge, 
// publish, distribute, sublicense, and/or sell copies of the Software, 
// and to permit persons to whom the Software is furnished to do so, 
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included 
// in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF 
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY 
// CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, 
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
// OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// 
// Contact Information
//
// mailto:rbo@acm.org
#endregion

//
// DO NOT EDIT THIS FILE!
//
// This file was generated automatically by
// astgenerator.boo on 4/16/2004 10:38:46 PM
//

namespace Boo.Lang.Compiler.Ast
{
	public interface IAstTransformer
	{			
		void OnCompileUnit(Boo.Lang.Compiler.Ast.CompileUnit node, ref Boo.Lang.Compiler.Ast.CompileUnit newNode);
			
		void OnSimpleTypeReference(Boo.Lang.Compiler.Ast.SimpleTypeReference node, ref Boo.Lang.Compiler.Ast.TypeReference newNode);
			
		void OnTupleTypeReference(Boo.Lang.Compiler.Ast.TupleTypeReference node, ref Boo.Lang.Compiler.Ast.TypeReference newNode);
			
		void OnNamespaceDeclaration(Boo.Lang.Compiler.Ast.NamespaceDeclaration node, ref Boo.Lang.Compiler.Ast.NamespaceDeclaration newNode);
			
		void OnImport(Boo.Lang.Compiler.Ast.Import node, ref Boo.Lang.Compiler.Ast.Import newNode);
			
		void OnModule(Boo.Lang.Compiler.Ast.Module node, ref Boo.Lang.Compiler.Ast.Module newNode);
			
		void OnClassDefinition(Boo.Lang.Compiler.Ast.ClassDefinition node, ref Boo.Lang.Compiler.Ast.ClassDefinition newNode);
			
		void OnInterfaceDefinition(Boo.Lang.Compiler.Ast.InterfaceDefinition node, ref Boo.Lang.Compiler.Ast.InterfaceDefinition newNode);
			
		void OnEnumDefinition(Boo.Lang.Compiler.Ast.EnumDefinition node, ref Boo.Lang.Compiler.Ast.EnumDefinition newNode);
			
		void OnEnumMember(Boo.Lang.Compiler.Ast.EnumMember node, ref Boo.Lang.Compiler.Ast.EnumMember newNode);
			
		void OnField(Boo.Lang.Compiler.Ast.Field node, ref Boo.Lang.Compiler.Ast.Field newNode);
			
		void OnProperty(Boo.Lang.Compiler.Ast.Property node, ref Boo.Lang.Compiler.Ast.Property newNode);
			
		void OnLocal(Boo.Lang.Compiler.Ast.Local node, ref Boo.Lang.Compiler.Ast.Local newNode);
			
		void OnMethod(Boo.Lang.Compiler.Ast.Method node, ref Boo.Lang.Compiler.Ast.Method newNode);
			
		void OnConstructor(Boo.Lang.Compiler.Ast.Constructor node, ref Boo.Lang.Compiler.Ast.Constructor newNode);
			
		void OnParameterDeclaration(Boo.Lang.Compiler.Ast.ParameterDeclaration node, ref Boo.Lang.Compiler.Ast.ParameterDeclaration newNode);
			
		void OnDeclaration(Boo.Lang.Compiler.Ast.Declaration node, ref Boo.Lang.Compiler.Ast.Declaration newNode);
			
		void OnAttribute(Boo.Lang.Compiler.Ast.Attribute node, ref Boo.Lang.Compiler.Ast.Attribute newNode);
			
		void OnStatementModifier(Boo.Lang.Compiler.Ast.StatementModifier node, ref Boo.Lang.Compiler.Ast.StatementModifier newNode);
			
		void OnBlock(Boo.Lang.Compiler.Ast.Block node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnDeclarationStatement(Boo.Lang.Compiler.Ast.DeclarationStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnAssertStatement(Boo.Lang.Compiler.Ast.AssertStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnMacroStatement(Boo.Lang.Compiler.Ast.MacroStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnTryStatement(Boo.Lang.Compiler.Ast.TryStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnExceptionHandler(Boo.Lang.Compiler.Ast.ExceptionHandler node, ref Boo.Lang.Compiler.Ast.ExceptionHandler newNode);
			
		void OnIfStatement(Boo.Lang.Compiler.Ast.IfStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnUnlessStatement(Boo.Lang.Compiler.Ast.UnlessStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnForStatement(Boo.Lang.Compiler.Ast.ForStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnWhileStatement(Boo.Lang.Compiler.Ast.WhileStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnGivenStatement(Boo.Lang.Compiler.Ast.GivenStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnWhenClause(Boo.Lang.Compiler.Ast.WhenClause node, ref Boo.Lang.Compiler.Ast.WhenClause newNode);
			
		void OnBreakStatement(Boo.Lang.Compiler.Ast.BreakStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnContinueStatement(Boo.Lang.Compiler.Ast.ContinueStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnRetryStatement(Boo.Lang.Compiler.Ast.RetryStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnReturnStatement(Boo.Lang.Compiler.Ast.ReturnStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnYieldStatement(Boo.Lang.Compiler.Ast.YieldStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnRaiseStatement(Boo.Lang.Compiler.Ast.RaiseStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnUnpackStatement(Boo.Lang.Compiler.Ast.UnpackStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnExpressionStatement(Boo.Lang.Compiler.Ast.ExpressionStatement node, ref Boo.Lang.Compiler.Ast.Statement newNode);
			
		void OnOmittedExpression(Boo.Lang.Compiler.Ast.OmittedExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnExpressionPair(Boo.Lang.Compiler.Ast.ExpressionPair node, ref Boo.Lang.Compiler.Ast.ExpressionPair newNode);
			
		void OnMethodInvocationExpression(Boo.Lang.Compiler.Ast.MethodInvocationExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnUnaryExpression(Boo.Lang.Compiler.Ast.UnaryExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnBinaryExpression(Boo.Lang.Compiler.Ast.BinaryExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnTernaryExpression(Boo.Lang.Compiler.Ast.TernaryExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnReferenceExpression(Boo.Lang.Compiler.Ast.ReferenceExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnMemberReferenceExpression(Boo.Lang.Compiler.Ast.MemberReferenceExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnStringLiteralExpression(Boo.Lang.Compiler.Ast.StringLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnTimeSpanLiteralExpression(Boo.Lang.Compiler.Ast.TimeSpanLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnIntegerLiteralExpression(Boo.Lang.Compiler.Ast.IntegerLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnDoubleLiteralExpression(Boo.Lang.Compiler.Ast.DoubleLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnNullLiteralExpression(Boo.Lang.Compiler.Ast.NullLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnSelfLiteralExpression(Boo.Lang.Compiler.Ast.SelfLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnSuperLiteralExpression(Boo.Lang.Compiler.Ast.SuperLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnBoolLiteralExpression(Boo.Lang.Compiler.Ast.BoolLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnRELiteralExpression(Boo.Lang.Compiler.Ast.RELiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnStringFormattingExpression(Boo.Lang.Compiler.Ast.StringFormattingExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnHashLiteralExpression(Boo.Lang.Compiler.Ast.HashLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnListLiteralExpression(Boo.Lang.Compiler.Ast.ListLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnTupleLiteralExpression(Boo.Lang.Compiler.Ast.TupleLiteralExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnIteratorExpression(Boo.Lang.Compiler.Ast.IteratorExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnSlicingExpression(Boo.Lang.Compiler.Ast.SlicingExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnAsExpression(Boo.Lang.Compiler.Ast.AsExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnCastExpression(Boo.Lang.Compiler.Ast.CastExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);
			
		void OnTypeofExpression(Boo.Lang.Compiler.Ast.TypeofExpression node, ref Boo.Lang.Compiler.Ast.Expression newNode);

	}
}