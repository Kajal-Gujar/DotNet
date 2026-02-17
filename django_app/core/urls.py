"""
URL configuration for the core app.
This demonstrates the URL routing part of Django's MVT architecture.
"""
from django.urls import path
from . import views

app_name = 'core'

urlpatterns = [
    path('', views.index, name='index'),
    path('about/', views.about, name='about'),
]
