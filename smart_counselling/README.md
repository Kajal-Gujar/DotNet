# Smart Counselling Django Project

A Django-based smart counselling system for educational guidance and college admissions.

## Project Structure

```
smart_counselling/
│
├── accounts/          # User authentication and account management
├── exams/             # Exam information and management
├── colleges/          # College database and information
├── prediction/        # College admission prediction system
├── counselling/       # Counselling sessions and guidance
├── resources/         # Educational resources and materials
├── notifications/     # Notification system
├── payments/          # Payment processing
├── reviews/           # User reviews and ratings
├── dashboard/         # User dashboard and analytics
│
└── smart_counselling/ # Main project configuration
```

## Getting Started

### Prerequisites

- Python 3.8 or higher
- Django 6.0 or higher

### Installation

1. Install dependencies:
```bash
pip install -r requirements.txt
```

2. Run migrations:
```bash
python manage.py migrate
```

3. Create a superuser:
```bash
python manage.py createsuperuser
```

4. Run the development server:
```bash
python manage.py runserver
```

5. Access the application at `http://localhost:8000`

## Apps Description

- **accounts**: Handles user registration, login, and profile management
- **exams**: Manages various entrance exams and their details
- **colleges**: Contains college information, courses, and admission criteria
- **prediction**: Provides college admission predictions based on exam scores
- **counselling**: Manages counselling sessions and expert guidance
- **resources**: Stores study materials and resources for students
- **notifications**: Sends notifications to users about updates and deadlines
- **payments**: Handles payment processing for premium features
- **reviews**: Allows users to review colleges and share experiences
- **dashboard**: Provides personalized dashboard with analytics and insights

## Development

This project follows Django best practices and conventions. Each app is modular and can be developed independently.

## License

This project is part of the DotNet repository.
