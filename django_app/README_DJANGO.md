# Django Project Setup Guide

This directory contains a Django project configured with PostgreSQL, demonstrating the MVT (Model-View-Template) architecture.

## 📁 Project Structure

```
django_app/
├── manage.py              # Django management command-line utility
├── requirements.txt       # Python dependencies
├── mysite/               # Django project configuration
│   ├── __init__.py
│   ├── settings.py       # Project settings (DATABASE CONFIG HERE!)
│   ├── urls.py          # Main URL routing
│   ├── asgi.py          # ASGI config for async
│   └── wsgi.py          # WSGI config for deployment
└── core/                # Example app demonstrating MVT
    ├── __init__.py
    ├── models.py        # M - Model layer (Task model)
    ├── views.py         # V - View layer (business logic)
    ├── urls.py          # URL patterns for core app
    ├── admin.py         # Django admin configuration
    ├── apps.py          # App configuration
    ├── tests.py         # Unit tests
    ├── migrations/      # Database migrations
    └── templates/       # T - Template layer (HTML)
        └── core/
            ├── base.html
            ├── index.html
            └── about.html
```

## 🚀 Getting Started

### 1. Opening the Project in VS Code

**IMPORTANT**: To avoid the "no valid workspace folder" error in VS Code, open the **`django_app`** folder specifically, not the root `DotNet` folder.

**Option A: Open from command line**
```bash
cd /path/to/DotNet/django_app
code .
```

**Option B: Open from VS Code**
1. Open VS Code
2. File → Open Folder...
3. Navigate to `DotNet/django_app` directory
4. Click "Select Folder"

### 2. Create a Virtual Environment

**On Windows:**
```bash
python -m venv venv
venv\Scripts\activate
```

**On macOS/Linux:**
```bash
python3 -m venv venv
source venv/bin/activate
```

You should see `(venv)` in your terminal prompt after activation.

### 3. Install Dependencies

```bash
pip install -r requirements.txt
```

This installs:
- Django 6.0.2
- psycopg2-binary (PostgreSQL adapter)

### 4. Configure PostgreSQL Database

**Step 1: Install PostgreSQL**
- Download from: https://www.postgresql.org/download/
- Or use a cloud service like ElephantSQL, Render, or Neon

**Step 2: Create a Database**
```sql
-- Using psql or pgAdmin:
CREATE DATABASE mydatabase;
CREATE USER myuser WITH PASSWORD 'mypassword';
ALTER ROLE myuser SET client_encoding TO 'utf8';
ALTER ROLE myuser SET default_transaction_isolation TO 'read committed';
ALTER ROLE myuser SET timezone TO 'UTC';
GRANT ALL PRIVILEGES ON DATABASE mydatabase TO myuser;
```

**Step 3: Update Database Settings**

Edit `mysite/settings.py` and update the `DATABASES` configuration:

```python
DATABASES = {
    'default': {
        'ENGINE': 'django.db.backends.postgresql',
        'NAME': 'mydatabase',      # Your database name
        'USER': 'myuser',          # Your PostgreSQL username
        'PASSWORD': 'mypassword',  # Your PostgreSQL password
        'HOST': 'localhost',       # Your PostgreSQL host
        'PORT': '5432',            # Your PostgreSQL port
    }
}
```

**Optional: Use SQLite for Quick Testing**

If you want to test the app without setting up PostgreSQL immediately, you can temporarily use SQLite by uncommenting the alternative configuration in `settings.py`:

```python
DATABASES = {
    'default': {
        'ENGINE': 'django.db.backends.sqlite3',
        'NAME': BASE_DIR / 'db.sqlite3',
    }
}
```

### 5. Run Migrations

Apply database migrations to create the necessary tables:

```bash
python manage.py makemigrations
python manage.py migrate
```

### 6. Create a Superuser

Create an admin account to access the Django admin panel:

```bash
python manage.py createsuperuser
```

Follow the prompts to enter:
- Username
- Email address (optional)
- Password

### 7. Run the Development Server

Start the Django development server:

```bash
python manage.py runserver
```

The server will start at `http://127.0.0.1:8000/`

### 8. Access the Application

Open your browser and visit:
- **Home Page**: http://127.0.0.1:8000/
- **About Page**: http://127.0.0.1:8000/about/
- **Admin Panel**: http://127.0.0.1:8000/admin/

## 📚 Understanding the MVT Architecture

### Model (M) - `core/models.py`
Defines the data structure. The `Task` model includes:
- `title`: CharField for task title
- `description`: TextField for details
- `completed`: BooleanField for status
- `created_at` and `updated_at`: Timestamp fields

### View (V) - `core/views.py`
Contains business logic. Examples:
- `index()`: Fetches all tasks and renders them
- `about()`: Renders static about page

### Template (T) - `core/templates/core/`
HTML files with Django template language:
- `base.html`: Base template with common layout
- `index.html`: Home page extending base
- `about.html`: About page extending base

### URL Routing
- `mysite/urls.py`: Main URL configuration
- `core/urls.py`: App-specific URL patterns

## 🔧 Common Commands

```bash
# Activate virtual environment
source venv/bin/activate  # macOS/Linux
venv\Scripts\activate     # Windows

# Install/update dependencies
pip install -r requirements.txt

# Create new migrations
python manage.py makemigrations

# Apply migrations
python manage.py migrate

# Create superuser
python manage.py createsuperuser

# Run development server
python manage.py runserver

# Run on specific port
python manage.py runserver 8080

# Run tests
python manage.py test

# Start Django shell
python manage.py shell

# Collect static files (for production)
python manage.py collectstatic
```

## 📝 Adding New Features

### Creating a New App

```bash
python manage.py startapp myapp
```

Then add `'myapp'` to `INSTALLED_APPS` in `settings.py`.

### Creating a New Model

1. Define model in `models.py`
2. Run `python manage.py makemigrations`
3. Run `python manage.py migrate`
4. Register in `admin.py` for admin interface

### Adding New Views

1. Create view function in `views.py`
2. Add URL pattern in app's `urls.py`
3. Create corresponding template in `templates/app_name/`

## 🔒 Security Notes

- The `SECRET_KEY` in `settings.py` should be changed for production
- Never commit database credentials to version control
- Set `DEBUG = False` in production
- Configure `ALLOWED_HOSTS` for production deployment

## 🐛 Troubleshooting

### "No valid workspace folder" in VS Code
- Make sure you opened the `django_app` folder, not the parent directory
- VS Code should show `DJANGO_APP` in the window title

### Database connection errors
- Verify PostgreSQL is running: `sudo service postgresql status` (Linux)
- Check credentials in `settings.py`
- Ensure database exists: `psql -l` to list databases

### Migration errors
- Delete migration files (except `__init__.py`) and run `makemigrations` again
- Or reset: `python manage.py migrate --fake core zero` then migrate again

### Module not found errors
- Ensure virtual environment is activated
- Reinstall requirements: `pip install -r requirements.txt`

## 📦 Deployment Considerations

For production deployment:
1. Set `DEBUG = False`
2. Configure `ALLOWED_HOSTS`
3. Use environment variables for sensitive data
4. Set up proper static file serving
5. Use a production WSGI server (Gunicorn, uWSGI)
6. Configure HTTPS
7. Set up proper database backups

## 📚 Additional Resources

- [Django Documentation](https://docs.djangoproject.com/)
- [PostgreSQL Documentation](https://www.postgresql.org/docs/)
- [Django Tutorial](https://docs.djangoproject.com/en/6.0/intro/tutorial01/)
- [Django MVT Architecture](https://docs.djangoproject.com/en/6.0/faq/general/#django-appears-to-be-a-mvc-framework-but-you-call-the-controller-the-view-and-the-view-the-template-how-come-you-don-t-use-the-standard-names)

## 🤝 Contributing

Feel free to extend this project by:
- Adding more models and relationships
- Implementing forms for user input
- Adding authentication and authorization
- Creating RESTful APIs with Django REST Framework
- Adding frontend framework integration (React, Vue, etc.)

---

**Happy Coding! 🎉**
