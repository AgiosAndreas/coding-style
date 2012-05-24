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
		public event Action<string, string> ValueChanged;
		
		public const string SettingsFilePath = "Константа";

		private SettingsType _settingsType;
		protected int _itemsCount = 10;
		
		public int MaxValue { get; protected set; } // автопроперти в одну строчку
		

		public SettingsProvider() : this(SettingsType.InMemory)
		{
		}

		public SettingsProvider (SettingsType settingsType)
		{
			_settingsType = settingsType;
			MaxValue = 100;
		}

		
		public SettingsType SettingsType
		{
			get	{ return _settingsType; }
		}

		
		public void SetValue(string key, string value)
		{
			// Пример комментария к блоку кода
			// Дальше будет выполнена проверка параметров,
			// чтобы избежать выполнения метода с
			// неверными агрументами
			if (String.IsNullOrEmpty(key)) throw new ArgumentNullException("key");   //  String с большой буквы
			if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("value");

			// Пример кода к конкретной строке
			var invariantKey = key; 

			switch (_settingsType) // еще один вариант
			{
				case SettingsType.InMemory: 
					invariantKey = key.ToLower();
					break;
				case SettingsType.InFile:
					invariantKey = String.Format("{0}/{1}", SettingsFilePath, key);
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

			for (var i = 0; i < key.Length; i += 1) // += на мой взгляд красивее
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

		
		protected virtual void OnValueChanged(string key, string value)
		{
			ValueChanged.Raise(key, value); // для евентов использовать extension метод
		}

		
		private void Initialize()
		{

		}
	}
}