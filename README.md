# BindingManager
The idea for application started when using hundred time snippets for binding view with model properties. Enter the Property name and  variable type to generate code from the template eg. "Test int" will use template from file "int.templ".

## Usage Application:
If user gives int as a variable type, application will first search in "Templates" folder for the "int.templ" file and if it doesn't find it Manager will use the "auto.templ" file to generate code from the template. We can also leave an empty variable type (eg "Test") and then program will use the "default.templ" as template to generate the code from.

## Possible variables in templates:
- "__prop\__" - returns the property name (eg. Test)
- "__field\__" - returns the name of the field (eg. _test)
- "__type\__" - returns the variable type (eg. int)

Input: "Test int" will return:
- \_\_prop\_\_ - Test
- \_\_field\_\_ - _test
- \_\_type\_\_ - int

## Fast start:
1. Launch and close the application
2. Create the 'auto.templ' and 'default.templ' files in the Templates folder.
3. Create your own templates.
4. Generate code in the application

## Examples of templ files:

### command.templ (not required, it's custom template)
        #region __prop__Command
        private RelayCommand __field__Command;
        public RelayCommand __prop__Command
        {
            get
            {
                return __field__Command
                       ?? (__field__Command = new RelayCommand(__prop__CommandExecute,
					__prop__CommandCanExecute));
            }
        }

        public bool __prop__CommandCanExecute()
        {
            return true;
        }

        public void __prop__CommandExecute()
        {
            
        }
        #endregion

### auto.templ
	private __type__ __field__;
	public __type__ __prop__
		{
			get => __field__;
			set
			{
				if (__field__ == value) return;
				__field__ = value;
				OnPropertyChanged("__prop__");
			}
		}

### default.templ
	private string __field__;
	public string __prop__
		{
			get => __field__;
			set
			{
				if (__field__ == value) return;
				__field__ = value;
				OnPropertyChanged("__prop__");
			}
		}
