﻿//-----------------------------------------------------------------------
// <copyright file="ScalingTextBox.cs" company="None">
//     Copyright (c) Brandon Wallace and Jesse Calhoun. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
namespace TQVaultAE.GUI
{
	using System.Drawing;
	using System.Windows.Forms;

	/// <summary>
	/// TextBox class to support scaling of the fonts.
	/// </summary>
	public class ScalingTextBox : TextBox
	{
		/// <summary>
		/// Override of ScaleControl which supports font scaling.
		/// </summary>
		/// <param name="factor">SizeF for the scale factor</param>
		/// <param name="specified">BoundsSpecified value.</param>
		protected override void ScaleControl(SizeF factor, BoundsSpecified specified)
		{
			this.Font = new Font(this.Font.Name, this.Font.SizeInPoints * factor.Height, this.Font.Style);

			base.ScaleControl(factor, specified);
		}
	}
}