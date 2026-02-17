from django.test import TestCase
from django.urls import reverse
from .models import Task

# Create your tests here.

class TaskModelTest(TestCase):
    """Test cases for the Task model"""
    
    def setUp(self):
        """Set up test data"""
        self.task = Task.objects.create(
            title="Test Task",
            description="Test Description",
            completed=False
        )
    
    def test_task_creation(self):
        """Test that a task can be created"""
        self.assertEqual(self.task.title, "Test Task")
        self.assertEqual(self.task.description, "Test Description")
        self.assertFalse(self.task.completed)
    
    def test_task_str(self):
        """Test the string representation of a task"""
        self.assertEqual(str(self.task), "Test Task")
    
    def test_task_ordering(self):
        """Test that tasks are ordered by created_at descending"""
        task2 = Task.objects.create(title="Second Task")
        tasks = Task.objects.all()
        self.assertEqual(tasks[0], task2)  # Most recent first


class ViewsTest(TestCase):
    """Test cases for views"""
    
    def test_index_view(self):
        """Test the index view renders correctly"""
        response = self.client.get(reverse('core:index'))
        self.assertEqual(response.status_code, 200)
        self.assertTemplateUsed(response, 'core/index.html')
    
    def test_about_view(self):
        """Test the about view renders correctly"""
        response = self.client.get(reverse('core:about'))
        self.assertEqual(response.status_code, 200)
        self.assertTemplateUsed(response, 'core/about.html')
    
    def test_index_view_with_tasks(self):
        """Test the index view displays tasks"""
        Task.objects.create(title="Test Task", description="Test")
        response = self.client.get(reverse('core:index'))
        self.assertContains(response, "Test Task")
