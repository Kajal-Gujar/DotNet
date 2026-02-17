from django.shortcuts import render
from .models import Task

# Create your views here.

def index(request):
    """
    Home page view - demonstrates the View part of MVT architecture.
    This view retrieves all tasks from the database and passes them to the template.
    """
    tasks = Task.objects.all()
    context = {
        'tasks': tasks,
        'page_title': 'Django MVT Demo - Task List',
    }
    return render(request, 'core/index.html', context)

def about(request):
    """
    About page view - demonstrates a simple static page.
    """
    context = {
        'page_title': 'About This Project',
    }
    return render(request, 'core/about.html', context)
