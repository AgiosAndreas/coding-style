using System;
using System.Collections;

using Touchin.Core; 
using Touchin.ProjectName.Repositories;

namespace Touchin.ProjectName.Service
{

	public enum SettingsType
	{
		InMemory, // default settings mode
		InFile
	}

	public interface ISettingsProvider
	{
		void SetValue (string key, string value);
		string GetValue (string key);
	}


	public class SettingsProvider : ISettingsProvider
	{
		// Fields

		public const string SettingsFilePath = "Константа";

		SettingsType _settingsType;
		protected int _itemsCount = 10;



		// Constructors

		public SettingsProvider () : this (SettingsType.InMemory)
		{}

		public SettingsProvider (SettingsType settingsType)
		{
			_settingsType = settingsType;
			MaxValue = 100;
		}



		// Events

		public event Action<string,string> ValueChanged;



		// Properties

		public SettingsType SettingsType
		{
			get
			{
				return _settingsType;
			}
		}

		public int MaxValue
		{
			get;
			protected set;
		}



		// Methods


		public void SetValue (string key, string value)
		{
			// Пример комментария к блоку кода
			// Дальше будет выполнена проверка параметров,
			// чтобы избежать выполнения метода с
			// неверными агрументами

			if (string.IsNullOrEmpty (key)) throw new ArgumentNullException ("key");

			if (string.IsNullOrEmpty (value)) 
			{
				throw new ArgumentNullException ("value");
			}

			// Пример кода к конкретной строке
			var invariantKey = key; 

			switch (_settingsType) // еще один вариант
			{
				case SettingsType.InMemory: invariantKey = key.ToLower (); break;
				case SettingsType.InFile:
					invariantKey = string.Format ("{0}/{1}", SettingsFilePath, key);
					break;
			}

			// TODO: сохранить значение по ключу

			OnValueChanged(key, value);

		}

		public string GetValue (string key)
		{

			while (true)
			{
				// correct killer loop
			}

			for (int i = 0; i < key.Length; i++) 
			{

			}

			try
			{

			}
			catch
			{
				// TODO: log exception
				throw ex; // если не знаешь, как обработать исключение, то его лучше отпустить :)
			}

			using (disposable1)
			using (disposable2)
			{

			}
		}

		protected virtual void OnValueChanged (string key, string value)
		{
			var handler = ValueChanged;

			if (handler != null)
			{
				handler (key, value);
			}
		}

		private void Initialize()
		{

		}
	}
}