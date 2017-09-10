﻿using SabberStoneCore.Enums;
using System.Collections.Generic;

namespace SabberStoneCore.Model.Entities
{
	/// <summary>
	/// Entity which can be attached to a <see cref="Hero"/>.
	/// A weapon is comparable to a buff, because it gives more/stronger abilities to the
	/// controller's hero for a limited use.
	/// </summary>
	/// <seealso cref="Playable{Weapon}" />
	public partial class Weapon : Playable<Weapon>
	{
		/// <summary>Initializes a new instance of the <see cref="Weapon"/> class.</summary>
		/// <param name="controller">The controller.</param>
		/// <param name="card">The card.</param>
		/// <param name="tags">The tags.</param>
		/// <autogeneratedoc />
		public Weapon(Controller controller, Card card, Dictionary<GameTag, int> tags)
			: base(controller, card, tags)
		{
			Game.Log(LogLevel.INFO, BlockType.PLAY, "Weapon", $"{this} ({Card.Class}) was created.");
		}
	}

	public partial class Weapon
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	{
		public int AttackDamage
		{
			get { return this[GameTag.ATK]; }
			set { this[GameTag.ATK] = value; }
		}

		public int Durability
		{
			get { return this[GameTag.DURABILITY]; }
			set { this[GameTag.DURABILITY] = value; }
		}

		public bool HasWindfury
		{
			get { return this[GameTag.WINDFURY] == 1; }
			set { this[GameTag.WINDFURY] = value ? 1 : 0; }
		}

		public bool Poisonous
		{
			get { return this[GameTag.POISONOUS] == 1; }
			set { this[GameTag.POISONOUS] = value ? 1 : 0; }
		}
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
