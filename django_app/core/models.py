from django.db import models

# Create your models here.

class Task(models.Model):
    """
    A simple Task model to demonstrate the Model part of MVT architecture.
    This model represents a to-do task with a title, description, and completion status.
    """
    title = models.CharField(max_length=200, help_text="Title of the task")
    description = models.TextField(blank=True, help_text="Detailed description of the task")
    completed = models.BooleanField(default=False, help_text="Whether the task is completed")
    created_at = models.DateTimeField(auto_now_add=True, help_text="When the task was created")
    updated_at = models.DateTimeField(auto_now=True, help_text="When the task was last updated")

    class Meta:
        ordering = ['-created_at']  # Most recent tasks first
        verbose_name = 'Task'
        verbose_name_plural = 'Tasks'

    def __str__(self):
        return self.title
