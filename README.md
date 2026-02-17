# Django MVT Project

This is a Django project demonstrating the **MVT (Model-View-Template)** architecture pattern.

## Project Structure

```
DotNet/
├── myproject/              # Main project configuration
│   ├── settings.py         # Project settings
│   ├── urls.py            # Main URL configuration
│   ├── wsgi.py            # WSGI configuration
│   └── asgi.py            # ASGI configuration
├── blog/                  # Blog application
│   ├── models.py          # Post model
│   ├── views.py           # Blog views
│   ├── urls.py            # Blog URLs
│   ├── admin.py           # Admin configuration
│   └── templates/blog/    # Blog templates
├── users/                 # Users application
│   ├── models.py          # UserProfile model
│   ├── views.py           # User views
│   ├── urls.py            # User URLs
│   ├── admin.py           # Admin configuration
│   └── templates/users/   # User templates
├── core/                  # Core application
│   ├── views.py           # Core views (home, about)
│   ├── urls.py            # Core URLs
│   └── templates/core/    # Core templates
├── manage.py              # Django management script
├── requirements.txt       # Python dependencies
└── README.md             # This file
```

## MVT Architecture

### Model (M)
Models define the data structure and interact with the database.
- **blog/models.py**: Contains the `Post` model for blog posts
- **users/models.py**: Contains the `UserProfile` model for user profiles

### View (V)
Views handle the business logic and process user requests.
- **blog/views.py**: Contains views for listing and displaying blog posts
- **users/views.py**: Contains views for user profiles
- **core/views.py**: Contains views for home and about pages

### Template (T)
Templates render the HTML and display data to users.
- **blog/templates/blog/**: Contains blog-related templates
- **users/templates/users/**: Contains user-related templates
- **core/templates/core/**: Contains core templates (home, about)

## Setup Instructions

### 1. Install Dependencies

```bash
pip install -r requirements.txt
```

### 2. Run Migrations

```bash
python manage.py makemigrations
python manage.py migrate
```

### 3. Create Superuser (Optional)

```bash
python manage.py createsuperuser
```

### 4. Run Development Server

```bash
python manage.py runserver
```

The project will be available at `http://127.0.0.1:8000/`

## Available URLs

- `/` - Home page
- `/about/` - About page
- `/blog/` - Blog post list
- `/blog/post/<id>/` - Individual blog post
- `/users/profile/<username>/` - User profile
- `/admin/` - Django admin panel

## Apps Overview

### Blog App
- **Purpose**: Manage and display blog posts
- **Models**: Post (title, content, author, timestamps)
- **Views**: post_list, post_detail
- **Templates**: post_list.html, post_detail.html

### Users App
- **Purpose**: Manage user profiles
- **Models**: UserProfile (bio, location, birth_date)
- **Views**: profile_view
- **Templates**: profile.html

### Core App
- **Purpose**: Provide core functionality and static pages
- **Models**: None
- **Views**: home, about
- **Templates**: home.html, about.html

## Development

To add a new app:
```bash
python manage.py startapp <app_name>
```

Then add the app to `INSTALLED_APPS` in `myproject/settings.py`.

## Technologies Used

- Python 3.12+
- Django 6.0.2
- SQLite (default database)

## License

This project is created for educational purposes.
