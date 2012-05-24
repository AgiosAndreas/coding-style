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
		void SetValue(string key, string value);
		string GetValue(string key);
	}


	public delegate void ValueChangedHandler(string key, string value);


	public class SettingsProvider : ISettingsProvider
	{
		public event ValueChangedEventHandler ValueChanged;



		public const string SettingsFilePath = "Константа";

		private SettingsType _settingsType;
		protected int _itemsCount = 10;

		public int MaxValue { get; protected set; }



		public SettingsProvider() : this(SettingsType.InMemory)
		{}

		public SettingsProvider(SettingsType settingsType)
		{
			_settingsType = settingsType;
			MaxValue = 100;
		}



		public SettingsType Facade
		{
			get { return _protectedField; }
		}

		public SettingsType SettingsType
		{
			get 
			{ 
				return _settingsType; 
			}
			set 
			{ 
				NotifyPropertyChange(value);
				_settingsType = value;
			}
		}

		public string ProviderName
		{
			get
			{
				var providerName = "";

				// TODO: добавить код формирования имени

				return providerName;
			}
		}



		public void SetValue(string key, string value)
		{
			// Пример комментария к блоку кода
			// Дальше будет выполнена проверка параметров,
			// чтобы избежать выполнения метода с
			// неверными агрументами

			if (string.IsNullOrEmpty(key)) throw new ArgumentNullException("key");

			if (string.IsNullOrEmpty(value)) 
			{
				throw new ArgumentNullException("value");
			}

			// Пример кода к конкретной строке
			var invariantKey = key; 

			switch (_settingsType) // еще один вариант
			{
				case SettingsType.InMemory: 
					invariantKey = key.ToLower(); 
					break;
				case SettingsType.InFile:
					invariantKey = string.Format("{0}/{1}", SettingsFilePath, key);
					break;
			}

			// TODO: сохранить значение по ключу

			OnValueChanged(key, value);
		}

		public string GetValue(string key)
		{

			while (true)
			{
				// correct killer loop
			}

			for (var i = 0; i < key.Length; i++) 
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
			var handler = ValueChanged;

			if (handler != null)
			{
				handler(key, value);
			}
		}

		private void Initialize()
		{

		}
	}
}