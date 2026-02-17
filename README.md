# DotNet Repository - Mixed Technology Stack

This repository contains both .NET Windows Forms applications and a Django web application.

## 📂 Repository Structure

```
DotNet/
├── .NET Applications/
│   ├── Assignment1/
│   ├── Calculator/
│   ├── HospitalOPD/
│   ├── PersonalA/
│   ├── Railway Reservation/
│   ├── RentalForm/
│   ├── Student Registration/
│   ├── TableForm/
│   ├── TshirtAssignment/
│   ├── TshirtOdering/
│   ├── UserLogin/
│   ├── WindowsFormsApp6/
│   ├── WindowsFormsApp7/
│   └── oops03/
│
└── django_app/          # Django web application (NEW!)
    ├── README_DJANGO.md # Complete Django setup guide
    ├── requirements.txt
    ├── manage.py
    ├── mysite/         # Django project configuration
    └── core/           # Example app demonstrating MVT
```

## 🚀 Getting Started with Django

### Quick Start for VS Code Users

If you're seeing "no valid workspace folder open" error in VS Code:

1. **Open the Django folder specifically:**
   ```bash
   cd django_app
   code .
   ```
   Or: File → Open Folder... → Select `DotNet/django_app`

2. **Follow the complete setup guide:**
   Open and read: `django_app/README_DJANGO.md`

### Django Project Highlights

The `django_app/` directory contains a complete Django 6.0 project with:

✅ **PostgreSQL configuration** (requires user to add credentials)  
✅ **MVT architecture demonstration** with example Task model  
✅ **Django admin panel** for easy data management  
✅ **Example app (`core`)** with models, views, templates, and URLs  
✅ **Comprehensive documentation** for setup and usage  
✅ **Requirements file** with all dependencies  

### Technologies

- **Django 6.0.2** - Python web framework
- **PostgreSQL** - Relational database (configured, needs credentials)
- **psycopg2-binary** - PostgreSQL adapter
- **Python 3.12+** - Programming language

## 📚 Documentation

- **For Django setup**: See `django_app/README_DJANGO.md`
- **For .NET projects**: See individual project directories

## 🔧 Development Workflow

### Working with Django:
```bash
cd django_app
python -m venv venv
source venv/bin/activate  # On Windows: venv\Scripts\activate
pip install -r requirements.txt
python manage.py runserver
```

### Working with .NET:
Open the `.sln` files in Visual Studio or the project directories in your preferred .NET IDE.

## 📝 Notes

- The Django project is completely separate from the .NET applications
- Both technologies can coexist in the same repository
- Use the appropriate tools and IDEs for each technology stack
- Django files are in `django_app/` directory
- .NET files are in their respective project directories

## 🤝 Contributing

When adding new features:
- Keep Django-related changes in `django_app/`
- Keep .NET-related changes in their respective project directories
- Update documentation as needed

---

**Happy Coding!** 🎉
