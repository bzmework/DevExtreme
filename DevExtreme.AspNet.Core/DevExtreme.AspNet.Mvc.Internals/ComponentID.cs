namespace DevExtreme.AspNet.Mvc.Internals
{
	internal class ComponentID
	{
		private int _serial;

		private string _value;

		private bool _isExpr;

		public bool IsAssigned => !string.IsNullOrEmpty(_value);

		public bool IsExpr => _isExpr;

		internal ComponentID(int serial)
		{
			_serial = serial;
		}

		public string GetStatic()
		{
			if (_isExpr || !IsAssigned)
			{
				return "devextreme" + _serial.ToString();
			}
			return _value;
		}

		public void SetStatic(string id)
		{
			_value = id;
			_isExpr = false;
		}

		public void SetExpr(string expr)
		{
			_value = expr;
			_isExpr = true;
		}

		public object ToJS()
		{
			if (_isExpr)
			{
				return new JS(_value);
			}
			return GetStatic();
		}
	}
}
