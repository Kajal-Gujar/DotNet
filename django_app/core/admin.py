from django.contrib import admin
from .models import Task

# Register your models here.

@admin.register(Task)
class TaskAdmin(admin.ModelAdmin):
    """
    Admin interface for Task model - allows easy management through Django admin panel.
    """
    list_display = ('title', 'completed', 'created_at', 'updated_at')
    list_filter = ('completed', 'created_at')
    search_fields = ('title', 'description')
    list_editable = ('completed',)
    date_hierarchy = 'created_at'
